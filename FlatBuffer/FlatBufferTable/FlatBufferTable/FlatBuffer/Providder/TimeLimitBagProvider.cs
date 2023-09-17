using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_TimeLimitBagProvider
    {
        private static FB_TimeLimitBagProvider _Instance;
        public static FB_TimeLimitBagProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_TimeLimitBagProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/TimeLimitBag.txt";
        protected Dictionary<int, FB_TimeLimitBag> mData = new Dictionary<int, FB_TimeLimitBag>();
        private List<FB_TimeLimitBag> mListData = new List<FB_TimeLimitBag>();
        public List<FB_TimeLimitBag> ListData
        {
            get
            {
                var id = this.GetHashCode();
                if (mListData.Count <= 0)
                {
                    mListData.AddRange(mData.Values);
                }
                return mListData;
            }
        }
        public FB_TimeLimitBag GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_TimeLimitBag);
        }
        public Dictionary<int, FB_TimeLimitBag> GetData()
        {
            return mData;
        }
        public void LoadFromFile(string dataPath)
        {
            this.LoadData(new ByteBuffer(File.ReadAllBytes(dataPath)));
        }
        public void LoadFromMemory(byte[] dataBytes)
        {
            this.LoadData(new ByteBuffer(dataBytes));
        }
        public void LoadData(ByteBuffer bb) {
            if (!FB_TimeLimitBagContainer.FB_TimeLimitBagContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_TimeLimitBagContainer.GetRootAsFB_TimeLimitBagContainer(bb);
            for (int index = 0; index < data.ItemsLength; index++)
            {
                var item = data.GetItems(index);
                mData.Add(item.ID, item);
            }
            var id = this.GetHashCode();
        }
        public void Clear()
        {
            mData.Clear();
            mListData.Clear();
        }
    }
}
