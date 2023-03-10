using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_VIPInvestRewardProvider
    {
        private static FB_VIPInvestRewardProvider _Instance;
        public static FB_VIPInvestRewardProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_VIPInvestRewardProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/VIPInvestReward.txt";
        protected Dictionary<int, FB_VIPInvestReward> mData = new Dictionary<int, FB_VIPInvestReward>();
        private List<FB_VIPInvestReward> mListData = new List<FB_VIPInvestReward>();
        public List<FB_VIPInvestReward> ListData
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
        public FB_VIPInvestReward GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_VIPInvestReward);
        }
        public Dictionary<int, FB_VIPInvestReward> GetData()
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
            if (!FB_VIPInvestRewardContainer.FB_VIPInvestRewardContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_VIPInvestRewardContainer.GetRootAsFB_VIPInvestRewardContainer(bb);
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
