using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_MissionSectionRewardProvider
    {
        private static FB_MissionSectionRewardProvider _Instance;
        public static FB_MissionSectionRewardProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_MissionSectionRewardProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/MissionSectionReward.txt";
        protected Dictionary<int, FB_MissionSectionReward> mData = new Dictionary<int, FB_MissionSectionReward>();
        private List<FB_MissionSectionReward> mListData = new List<FB_MissionSectionReward>();
        public List<FB_MissionSectionReward> ListData
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
        public FB_MissionSectionReward GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_MissionSectionReward);
        }
        public Dictionary<int, FB_MissionSectionReward> GetData()
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
            if (!FB_MissionSectionRewardContainer.FB_MissionSectionRewardContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_MissionSectionRewardContainer.GetRootAsFB_MissionSectionRewardContainer(bb);
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
