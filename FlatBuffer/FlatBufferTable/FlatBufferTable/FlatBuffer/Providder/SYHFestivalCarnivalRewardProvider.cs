using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_SYHFestivalCarnivalRewardProvider
    {
        private static FB_SYHFestivalCarnivalRewardProvider _Instance;
        public static FB_SYHFestivalCarnivalRewardProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_SYHFestivalCarnivalRewardProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/SYHFestivalCarnivalReward.txt";
        protected Dictionary<int, FB_SYHFestivalCarnivalReward> mData = new Dictionary<int, FB_SYHFestivalCarnivalReward>();
        private List<FB_SYHFestivalCarnivalReward> mListData = new List<FB_SYHFestivalCarnivalReward>();
        public List<FB_SYHFestivalCarnivalReward> ListData
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
        public FB_SYHFestivalCarnivalReward GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_SYHFestivalCarnivalReward);
        }
        public Dictionary<int, FB_SYHFestivalCarnivalReward> GetData()
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
            if (!FB_SYHFestivalCarnivalRewardContainer.FB_SYHFestivalCarnivalRewardContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_SYHFestivalCarnivalRewardContainer.GetRootAsFB_SYHFestivalCarnivalRewardContainer(bb);
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
