using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_CopySceneShopProvider
    {
        private static FB_CopySceneShopProvider _Instance;
        public static FB_CopySceneShopProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_CopySceneShopProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/CopySceneShop.txt";
        protected Dictionary<int, FB_CopySceneShop> mData = new Dictionary<int, FB_CopySceneShop>();
        private List<FB_CopySceneShop> mListData = new List<FB_CopySceneShop>();
        public List<FB_CopySceneShop> ListData
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
        public FB_CopySceneShop GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_CopySceneShop);
        }
        public Dictionary<int, FB_CopySceneShop> GetData()
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
            if (!FB_CopySceneShopContainer.FB_CopySceneShopContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_CopySceneShopContainer.GetRootAsFB_CopySceneShopContainer(bb);
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
