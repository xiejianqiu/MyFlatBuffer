using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_EternalTreasureProvider
    {
        private static FB_EternalTreasureProvider _Instance;
        public static FB_EternalTreasureProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_EternalTreasureProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/EternalTreasure.txt";
        protected Dictionary<int, FB_EternalTreasure> mData = new Dictionary<int, FB_EternalTreasure>();
        private List<FB_EternalTreasure> mListData = new List<FB_EternalTreasure>();
        public List<FB_EternalTreasure> ListData
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
        public FB_EternalTreasure GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_EternalTreasure);
        }
        public Dictionary<int, FB_EternalTreasure> GetData()
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
            if (!FB_EternalTreasureContainer.FB_EternalTreasureContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_EternalTreasureContainer.GetRootAsFB_EternalTreasureContainer(bb);
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
