using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_MarryShopItemProvider
    {
        private static FB_MarryShopItemProvider _Instance;
        public static FB_MarryShopItemProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_MarryShopItemProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/MarryShopItem.txt";
        protected Dictionary<int, FB_MarryShopItem> mData = new Dictionary<int, FB_MarryShopItem>();
        private List<FB_MarryShopItem> mListData = new List<FB_MarryShopItem>();
        public List<FB_MarryShopItem> ListData
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
        public FB_MarryShopItem GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_MarryShopItem);
        }
        public Dictionary<int, FB_MarryShopItem> GetData()
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
            if (!FB_MarryShopItemContainer.FB_MarryShopItemContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_MarryShopItemContainer.GetRootAsFB_MarryShopItemContainer(bb);
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
