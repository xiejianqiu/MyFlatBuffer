using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_StarWishItemProvider
    {
        private static FB_StarWishItemProvider _Instance;
        public static FB_StarWishItemProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_StarWishItemProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/StarWishItem.txt";
        protected Dictionary<int, FB_StarWishItem> mData = new Dictionary<int, FB_StarWishItem>();
        private List<FB_StarWishItem> mListData = new List<FB_StarWishItem>();
        public List<FB_StarWishItem> ListData
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
        public FB_StarWishItem GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_StarWishItem);
        }
        public Dictionary<int, FB_StarWishItem> GetData()
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
            if (!FB_StarWishItemContainer.FB_StarWishItemContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_StarWishItemContainer.GetRootAsFB_StarWishItemContainer(bb);
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
