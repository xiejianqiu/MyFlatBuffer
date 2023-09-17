using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_ActWanGuPropLevelRewardProvider
    {
        private static FB_ActWanGuPropLevelRewardProvider _Instance;
        public static FB_ActWanGuPropLevelRewardProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_ActWanGuPropLevelRewardProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/ActWanGuPropLevelReward.txt";
        protected Dictionary<int, FB_ActWanGuPropLevelReward> mData = new Dictionary<int, FB_ActWanGuPropLevelReward>();
        private List<FB_ActWanGuPropLevelReward> mListData = new List<FB_ActWanGuPropLevelReward>();
        public List<FB_ActWanGuPropLevelReward> ListData
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
        public FB_ActWanGuPropLevelReward GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_ActWanGuPropLevelReward);
        }
        public Dictionary<int, FB_ActWanGuPropLevelReward> GetData()
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
            if (!FB_ActWanGuPropLevelRewardContainer.FB_ActWanGuPropLevelRewardContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_ActWanGuPropLevelRewardContainer.GetRootAsFB_ActWanGuPropLevelRewardContainer(bb);
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
