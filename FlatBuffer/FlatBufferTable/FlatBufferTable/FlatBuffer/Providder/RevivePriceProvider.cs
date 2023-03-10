using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_RevivePriceProvider
    {
        private static FB_RevivePriceProvider _Instance;
        public static FB_RevivePriceProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_RevivePriceProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/RevivePrice.txt";
        protected Dictionary<int, FB_RevivePrice> mData = new Dictionary<int, FB_RevivePrice>();
        private List<FB_RevivePrice> mListData = new List<FB_RevivePrice>();
        public List<FB_RevivePrice> ListData
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
        public FB_RevivePrice GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_RevivePrice);
        }
        public Dictionary<int, FB_RevivePrice> GetData()
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
            if (!FB_RevivePriceContainer.FB_RevivePriceContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_RevivePriceContainer.GetRootAsFB_RevivePriceContainer(bb);
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
