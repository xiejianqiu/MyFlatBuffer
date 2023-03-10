using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_RechargeGiftProvider
    {
        private static FB_RechargeGiftProvider _Instance;
        public static FB_RechargeGiftProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_RechargeGiftProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/RechargeGift.txt";
        protected Dictionary<int, FB_RechargeGift> mData = new Dictionary<int, FB_RechargeGift>();
        private List<FB_RechargeGift> mListData = new List<FB_RechargeGift>();
        public List<FB_RechargeGift> ListData
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
        public FB_RechargeGift GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_RechargeGift);
        }
        public Dictionary<int, FB_RechargeGift> GetData()
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
            if (!FB_RechargeGiftContainer.FB_RechargeGiftContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_RechargeGiftContainer.GetRootAsFB_RechargeGiftContainer(bb);
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
