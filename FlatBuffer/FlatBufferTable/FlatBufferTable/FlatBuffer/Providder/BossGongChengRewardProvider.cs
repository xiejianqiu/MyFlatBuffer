using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_BossGongChengRewardProvider
    {
        private static FB_BossGongChengRewardProvider _Instance;
        public static FB_BossGongChengRewardProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_BossGongChengRewardProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/BossGongChengReward.txt";
        protected Dictionary<int, FB_BossGongChengReward> mData = new Dictionary<int, FB_BossGongChengReward>();
        private List<FB_BossGongChengReward> mListData = new List<FB_BossGongChengReward>();
        public List<FB_BossGongChengReward> ListData
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
        public FB_BossGongChengReward GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_BossGongChengReward);
        }
        public Dictionary<int, FB_BossGongChengReward> GetData()
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
            if (!FB_BossGongChengRewardContainer.FB_BossGongChengRewardContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_BossGongChengRewardContainer.GetRootAsFB_BossGongChengRewardContainer(bb);
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
