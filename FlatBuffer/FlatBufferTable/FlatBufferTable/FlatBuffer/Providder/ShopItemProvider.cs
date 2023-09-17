using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_ShopItemProvider
    {
        private static FB_ShopItemProvider _Instance;
        public static FB_ShopItemProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_ShopItemProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/ShopItem.txt";
        protected Dictionary<int, FB_ShopItem> mData = new Dictionary<int, FB_ShopItem>();
        private List<FB_ShopItem> mListData = new List<FB_ShopItem>();
        public List<FB_ShopItem> ListData
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
        public FB_ShopItem GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_ShopItem);
        }
        public Dictionary<int, FB_ShopItem> GetData()
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
            if (!FB_ShopItemContainer.FB_ShopItemContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_ShopItemContainer.GetRootAsFB_ShopItemContainer(bb);
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
