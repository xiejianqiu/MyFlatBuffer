using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_EternalTreasureRewardProvider
    {
        private static FB_EternalTreasureRewardProvider _Instance;
        public static FB_EternalTreasureRewardProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_EternalTreasureRewardProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/EternalTreasureReward.txt";
        protected Dictionary<int, FB_EternalTreasureReward> mData = new Dictionary<int, FB_EternalTreasureReward>();
        private List<FB_EternalTreasureReward> mListData = new List<FB_EternalTreasureReward>();
        public List<FB_EternalTreasureReward> ListData
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
        public FB_EternalTreasureReward GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_EternalTreasureReward);
        }
        public Dictionary<int, FB_EternalTreasureReward> GetData()
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
            if (!FB_EternalTreasureRewardContainer.FB_EternalTreasureRewardContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_EternalTreasureRewardContainer.GetRootAsFB_EternalTreasureRewardContainer(bb);
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
