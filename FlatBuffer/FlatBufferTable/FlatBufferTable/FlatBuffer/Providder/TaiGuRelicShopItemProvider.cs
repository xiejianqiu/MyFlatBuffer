using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_TaiGuRelicShopItemProvider
    {
        private static FB_TaiGuRelicShopItemProvider _Instance;
        public static FB_TaiGuRelicShopItemProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_TaiGuRelicShopItemProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/TaiGuRelicShopItem.txt";
        protected Dictionary<int, FB_TaiGuRelicShopItem> mData = new Dictionary<int, FB_TaiGuRelicShopItem>();
        private List<FB_TaiGuRelicShopItem> mListData = new List<FB_TaiGuRelicShopItem>();
        public List<FB_TaiGuRelicShopItem> ListData
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
        public FB_TaiGuRelicShopItem GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_TaiGuRelicShopItem);
        }
        public Dictionary<int, FB_TaiGuRelicShopItem> GetData()
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
            if (!FB_TaiGuRelicShopItemContainer.FB_TaiGuRelicShopItemContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_TaiGuRelicShopItemContainer.GetRootAsFB_TaiGuRelicShopItemContainer(bb);
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
