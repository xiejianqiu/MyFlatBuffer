using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_IapGiftRewardProvider
    {
        private static FB_IapGiftRewardProvider _Instance;
        public static FB_IapGiftRewardProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_IapGiftRewardProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/IapGiftReward.txt";
        protected Dictionary<int, FB_IapGiftReward> mData = new Dictionary<int, FB_IapGiftReward>();
        private List<FB_IapGiftReward> mListData = new List<FB_IapGiftReward>();
        public List<FB_IapGiftReward> ListData
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
        public FB_IapGiftReward GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_IapGiftReward);
        }
        public Dictionary<int, FB_IapGiftReward> GetData()
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
            if (!FB_IapGiftRewardContainer.FB_IapGiftRewardContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_IapGiftRewardContainer.GetRootAsFB_IapGiftRewardContainer(bb);
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
