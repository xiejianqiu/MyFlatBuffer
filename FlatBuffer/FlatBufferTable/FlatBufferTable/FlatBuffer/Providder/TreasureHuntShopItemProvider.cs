using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_TreasureHuntShopItemProvider
    {
        private static FB_TreasureHuntShopItemProvider _Instance;
        public static FB_TreasureHuntShopItemProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_TreasureHuntShopItemProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/TreasureHuntShopItem.txt";
        protected Dictionary<int, FB_TreasureHuntShopItem> mData = new Dictionary<int, FB_TreasureHuntShopItem>();
        private List<FB_TreasureHuntShopItem> mListData = new List<FB_TreasureHuntShopItem>();
        public List<FB_TreasureHuntShopItem> ListData
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
        public FB_TreasureHuntShopItem GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_TreasureHuntShopItem);
        }
        public Dictionary<int, FB_TreasureHuntShopItem> GetData()
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
            if (!FB_TreasureHuntShopItemContainer.FB_TreasureHuntShopItemContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_TreasureHuntShopItemContainer.GetRootAsFB_TreasureHuntShopItemContainer(bb);
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
