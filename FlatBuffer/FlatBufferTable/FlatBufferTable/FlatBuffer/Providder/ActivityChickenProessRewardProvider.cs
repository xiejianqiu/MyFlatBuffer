using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_ActivityChickenProessRewardProvider
    {
        private static FB_ActivityChickenProessRewardProvider _Instance;
        public static FB_ActivityChickenProessRewardProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_ActivityChickenProessRewardProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/ActivityChickenProessReward.txt";
        protected Dictionary<int, FB_ActivityChickenProessReward> mData = new Dictionary<int, FB_ActivityChickenProessReward>();
        private List<FB_ActivityChickenProessReward> mListData = new List<FB_ActivityChickenProessReward>();
        public List<FB_ActivityChickenProessReward> ListData
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
        public FB_ActivityChickenProessReward GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_ActivityChickenProessReward);
        }
        public Dictionary<int, FB_ActivityChickenProessReward> GetData()
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
            if (!FB_ActivityChickenProessRewardContainer.FB_ActivityChickenProessRewardContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_ActivityChickenProessRewardContainer.GetRootAsFB_ActivityChickenProessRewardContainer(bb);
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
