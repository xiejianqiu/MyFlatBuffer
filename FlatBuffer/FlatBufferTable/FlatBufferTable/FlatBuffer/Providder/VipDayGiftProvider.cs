using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_VipDayGiftProvider
    {
        private static FB_VipDayGiftProvider _Instance;
        public static FB_VipDayGiftProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_VipDayGiftProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/VipDayGift.txt";
        protected Dictionary<int, FB_VipDayGift> mData = new Dictionary<int, FB_VipDayGift>();
        private List<FB_VipDayGift> mListData = new List<FB_VipDayGift>();
        public List<FB_VipDayGift> ListData
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
        public FB_VipDayGift GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_VipDayGift);
        }
        public Dictionary<int, FB_VipDayGift> GetData()
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
            if (!FB_VipDayGiftContainer.FB_VipDayGiftContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_VipDayGiftContainer.GetRootAsFB_VipDayGiftContainer(bb);
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
