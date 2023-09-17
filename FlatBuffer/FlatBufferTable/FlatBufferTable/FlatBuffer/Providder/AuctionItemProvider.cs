using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_AuctionItemProvider
    {
        private static FB_AuctionItemProvider _Instance;
        public static FB_AuctionItemProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_AuctionItemProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/AuctionItem.txt";
        protected Dictionary<int, FB_AuctionItem> mData = new Dictionary<int, FB_AuctionItem>();
        private List<FB_AuctionItem> mListData = new List<FB_AuctionItem>();
        public List<FB_AuctionItem> ListData
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
        public FB_AuctionItem GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_AuctionItem);
        }
        public Dictionary<int, FB_AuctionItem> GetData()
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
            if (!FB_AuctionItemContainer.FB_AuctionItemContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_AuctionItemContainer.GetRootAsFB_AuctionItemContainer(bb);
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
