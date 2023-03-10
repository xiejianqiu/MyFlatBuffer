using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_PurchaseAndRestitutProvider
    {
        private static FB_PurchaseAndRestitutProvider _Instance;
        public static FB_PurchaseAndRestitutProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_PurchaseAndRestitutProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/PurchaseAndRestitut.txt";
        protected Dictionary<int, FB_PurchaseAndRestitut> mData = new Dictionary<int, FB_PurchaseAndRestitut>();
        private List<FB_PurchaseAndRestitut> mListData = new List<FB_PurchaseAndRestitut>();
        public List<FB_PurchaseAndRestitut> ListData
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
        public FB_PurchaseAndRestitut GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_PurchaseAndRestitut);
        }
        public Dictionary<int, FB_PurchaseAndRestitut> GetData()
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
            if (!FB_PurchaseAndRestitutContainer.FB_PurchaseAndRestitutContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_PurchaseAndRestitutContainer.GetRootAsFB_PurchaseAndRestitutContainer(bb);
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
