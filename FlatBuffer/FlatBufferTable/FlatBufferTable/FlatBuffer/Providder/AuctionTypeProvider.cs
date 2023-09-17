using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_AuctionTypeProvider
    {
        private static FB_AuctionTypeProvider _Instance;
        public static FB_AuctionTypeProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_AuctionTypeProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/AuctionType.txt";
        protected Dictionary<int, FB_AuctionType> mData = new Dictionary<int, FB_AuctionType>();
        private List<FB_AuctionType> mListData = new List<FB_AuctionType>();
        public List<FB_AuctionType> ListData
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
        public FB_AuctionType GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_AuctionType);
        }
        public Dictionary<int, FB_AuctionType> GetData()
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
            if (!FB_AuctionTypeContainer.FB_AuctionTypeContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_AuctionTypeContainer.GetRootAsFB_AuctionTypeContainer(bb);
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
