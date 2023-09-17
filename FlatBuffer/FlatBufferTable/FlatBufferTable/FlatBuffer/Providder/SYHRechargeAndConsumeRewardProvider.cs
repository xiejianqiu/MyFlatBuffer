using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_SYHRechargeAndConsumeRewardProvider
    {
        private static FB_SYHRechargeAndConsumeRewardProvider _Instance;
        public static FB_SYHRechargeAndConsumeRewardProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_SYHRechargeAndConsumeRewardProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/SYHRechargeAndConsumeReward.txt";
        protected Dictionary<int, FB_SYHRechargeAndConsumeReward> mData = new Dictionary<int, FB_SYHRechargeAndConsumeReward>();
        private List<FB_SYHRechargeAndConsumeReward> mListData = new List<FB_SYHRechargeAndConsumeReward>();
        public List<FB_SYHRechargeAndConsumeReward> ListData
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
        public FB_SYHRechargeAndConsumeReward GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_SYHRechargeAndConsumeReward);
        }
        public Dictionary<int, FB_SYHRechargeAndConsumeReward> GetData()
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
            if (!FB_SYHRechargeAndConsumeRewardContainer.FB_SYHRechargeAndConsumeRewardContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_SYHRechargeAndConsumeRewardContainer.GetRootAsFB_SYHRechargeAndConsumeRewardContainer(bb);
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
