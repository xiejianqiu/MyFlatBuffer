using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_BagTreasureProvider
    {
        private static FB_BagTreasureProvider _Instance;
        public static FB_BagTreasureProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_BagTreasureProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/BagTreasure.txt";
        protected Dictionary<int, FB_BagTreasure> mData = new Dictionary<int, FB_BagTreasure>();
        private List<FB_BagTreasure> mListData = new List<FB_BagTreasure>();
        public List<FB_BagTreasure> ListData
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
        public FB_BagTreasure GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_BagTreasure);
        }
        public Dictionary<int, FB_BagTreasure> GetData()
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
            if (!FB_BagTreasureContainer.FB_BagTreasureContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_BagTreasureContainer.GetRootAsFB_BagTreasureContainer(bb);
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
