using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_ActivityChickenGiftProvider
    {
        private static FB_ActivityChickenGiftProvider _Instance;
        public static FB_ActivityChickenGiftProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_ActivityChickenGiftProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/ActivityChickenGift.txt";
        protected Dictionary<int, FB_ActivityChickenGift> mData = new Dictionary<int, FB_ActivityChickenGift>();
        private List<FB_ActivityChickenGift> mListData = new List<FB_ActivityChickenGift>();
        public List<FB_ActivityChickenGift> ListData
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
        public FB_ActivityChickenGift GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_ActivityChickenGift);
        }
        public Dictionary<int, FB_ActivityChickenGift> GetData()
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
            if (!FB_ActivityChickenGiftContainer.FB_ActivityChickenGiftContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_ActivityChickenGiftContainer.GetRootAsFB_ActivityChickenGiftContainer(bb);
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
