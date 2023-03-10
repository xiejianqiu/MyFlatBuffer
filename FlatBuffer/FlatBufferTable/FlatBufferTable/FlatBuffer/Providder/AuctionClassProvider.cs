using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_AuctionClassProvider
    {
        private static FB_AuctionClassProvider _Instance;
        public static FB_AuctionClassProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_AuctionClassProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/AuctionClass.txt";
        protected Dictionary<int, FB_AuctionClass> mData = new Dictionary<int, FB_AuctionClass>();
        private List<FB_AuctionClass> mListData = new List<FB_AuctionClass>();
        public List<FB_AuctionClass> ListData
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
        public FB_AuctionClass GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_AuctionClass);
        }
        public Dictionary<int, FB_AuctionClass> GetData()
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
            if (!FB_AuctionClassContainer.FB_AuctionClassContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_AuctionClassContainer.GetRootAsFB_AuctionClassContainer(bb);
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
