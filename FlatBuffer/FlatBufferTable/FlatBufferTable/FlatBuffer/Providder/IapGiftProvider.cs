using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_IapGiftProvider
    {
        private static FB_IapGiftProvider _Instance;
        public static FB_IapGiftProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_IapGiftProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/IapGift.txt";
        protected Dictionary<int, FB_IapGift> mData = new Dictionary<int, FB_IapGift>();
        private List<FB_IapGift> mListData = new List<FB_IapGift>();
        public List<FB_IapGift> ListData
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
        public FB_IapGift GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_IapGift);
        }
        public Dictionary<int, FB_IapGift> GetData()
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
            if (!FB_IapGiftContainer.FB_IapGiftContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_IapGiftContainer.GetRootAsFB_IapGiftContainer(bb);
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
