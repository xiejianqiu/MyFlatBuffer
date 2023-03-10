using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_VipEnjoyGiftProvider
    {
        private static FB_VipEnjoyGiftProvider _Instance;
        public static FB_VipEnjoyGiftProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_VipEnjoyGiftProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/VipEnjoyGift.txt";
        protected Dictionary<int, FB_VipEnjoyGift> mData = new Dictionary<int, FB_VipEnjoyGift>();
        private List<FB_VipEnjoyGift> mListData = new List<FB_VipEnjoyGift>();
        public List<FB_VipEnjoyGift> ListData
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
        public FB_VipEnjoyGift GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_VipEnjoyGift);
        }
        public Dictionary<int, FB_VipEnjoyGift> GetData()
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
            if (!FB_VipEnjoyGiftContainer.FB_VipEnjoyGiftContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_VipEnjoyGiftContainer.GetRootAsFB_VipEnjoyGiftContainer(bb);
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
