using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_MergeRankRewardProvider
    {
        private static FB_MergeRankRewardProvider _Instance;
        public static FB_MergeRankRewardProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_MergeRankRewardProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/MergeRankReward.txt";
        protected Dictionary<int, FB_MergeRankReward> mData = new Dictionary<int, FB_MergeRankReward>();
        private List<FB_MergeRankReward> mListData = new List<FB_MergeRankReward>();
        public List<FB_MergeRankReward> ListData
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
        public FB_MergeRankReward GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_MergeRankReward);
        }
        public Dictionary<int, FB_MergeRankReward> GetData()
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
            if (!FB_MergeRankRewardContainer.FB_MergeRankRewardContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_MergeRankRewardContainer.GetRootAsFB_MergeRankRewardContainer(bb);
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
