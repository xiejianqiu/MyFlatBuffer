using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_MissionLootItemProvider
    {
        private static FB_MissionLootItemProvider _Instance;
        public static FB_MissionLootItemProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_MissionLootItemProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/MissionLootItem.txt";
        protected Dictionary<int, FB_MissionLootItem> mData = new Dictionary<int, FB_MissionLootItem>();
        private List<FB_MissionLootItem> mListData = new List<FB_MissionLootItem>();
        public List<FB_MissionLootItem> ListData
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
        public FB_MissionLootItem GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_MissionLootItem);
        }
        public Dictionary<int, FB_MissionLootItem> GetData()
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
            if (!FB_MissionLootItemContainer.FB_MissionLootItemContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_MissionLootItemContainer.GetRootAsFB_MissionLootItemContainer(bb);
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
