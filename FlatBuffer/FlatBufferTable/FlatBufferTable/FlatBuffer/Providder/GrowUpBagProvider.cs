using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_GrowUpBagProvider
    {
        private static FB_GrowUpBagProvider _Instance;
        public static FB_GrowUpBagProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_GrowUpBagProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/GrowUpBag.txt";
        protected Dictionary<int, FB_GrowUpBag> mData = new Dictionary<int, FB_GrowUpBag>();
        private List<FB_GrowUpBag> mListData = new List<FB_GrowUpBag>();
        public List<FB_GrowUpBag> ListData
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
        public FB_GrowUpBag GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_GrowUpBag);
        }
        public Dictionary<int, FB_GrowUpBag> GetData()
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
            if (!FB_GrowUpBagContainer.FB_GrowUpBagContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_GrowUpBagContainer.GetRootAsFB_GrowUpBagContainer(bb);
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
