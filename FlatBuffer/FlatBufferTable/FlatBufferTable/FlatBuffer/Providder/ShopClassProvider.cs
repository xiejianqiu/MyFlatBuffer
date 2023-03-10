using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_ShopClassProvider
    {
        private static FB_ShopClassProvider _Instance;
        public static FB_ShopClassProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_ShopClassProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Client/ShopClass.txt";
        protected Dictionary<int, FB_ShopClass> mData = new Dictionary<int, FB_ShopClass>();
        private List<FB_ShopClass> mListData = new List<FB_ShopClass>();
        public List<FB_ShopClass> ListData
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
        public FB_ShopClass GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_ShopClass);
        }
        public Dictionary<int, FB_ShopClass> GetData()
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
            if (!FB_ShopClassContainer.FB_ShopClassContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_ShopClassContainer.GetRootAsFB_ShopClassContainer(bb);
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
