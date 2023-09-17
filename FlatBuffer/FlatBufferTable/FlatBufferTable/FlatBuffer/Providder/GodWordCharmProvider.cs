using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_GodWordCharmProvider
    {
        private static FB_GodWordCharmProvider _Instance;
        public static FB_GodWordCharmProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_GodWordCharmProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/GodWordCharm.txt";
        protected Dictionary<int, FB_GodWordCharm> mData = new Dictionary<int, FB_GodWordCharm>();
        private List<FB_GodWordCharm> mListData = new List<FB_GodWordCharm>();
        public List<FB_GodWordCharm> ListData
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
        public FB_GodWordCharm GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_GodWordCharm);
        }
        public Dictionary<int, FB_GodWordCharm> GetData()
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
            if (!FB_GodWordCharmContainer.FB_GodWordCharmContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_GodWordCharmContainer.GetRootAsFB_GodWordCharmContainer(bb);
            for (int index = 0; index < data.ItemsLength; index++)
            {
                var item = data.GetItems(index);
                mData.Add(item.Id, item);
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
