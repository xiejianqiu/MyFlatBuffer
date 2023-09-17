using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_AncientSealShopItemProvider
    {
        private static FB_AncientSealShopItemProvider _Instance;
        public static FB_AncientSealShopItemProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_AncientSealShopItemProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/AncientSealShopItem.txt";
        protected Dictionary<int, FB_AncientSealShopItem> mData = new Dictionary<int, FB_AncientSealShopItem>();
        private List<FB_AncientSealShopItem> mListData = new List<FB_AncientSealShopItem>();
        public List<FB_AncientSealShopItem> ListData
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
        public FB_AncientSealShopItem GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_AncientSealShopItem);
        }
        public Dictionary<int, FB_AncientSealShopItem> GetData()
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
            if (!FB_AncientSealShopItemContainer.FB_AncientSealShopItemContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_AncientSealShopItemContainer.GetRootAsFB_AncientSealShopItemContainer(bb);
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
