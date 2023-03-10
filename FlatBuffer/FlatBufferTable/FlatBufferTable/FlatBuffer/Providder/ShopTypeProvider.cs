using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_ShopTypeProvider
    {
        private static FB_ShopTypeProvider _Instance;
        public static FB_ShopTypeProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_ShopTypeProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/ShopType.txt";
        protected Dictionary<int, FB_ShopType> mData = new Dictionary<int, FB_ShopType>();
        private List<FB_ShopType> mListData = new List<FB_ShopType>();
        public List<FB_ShopType> ListData
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
        public FB_ShopType GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_ShopType);
        }
        public Dictionary<int, FB_ShopType> GetData()
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
            if (!FB_ShopTypeContainer.FB_ShopTypeContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_ShopTypeContainer.GetRootAsFB_ShopTypeContainer(bb);
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
