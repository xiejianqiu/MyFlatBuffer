using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_SpokesmanRewardProvider
    {
        private static FB_SpokesmanRewardProvider _Instance;
        public static FB_SpokesmanRewardProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_SpokesmanRewardProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/SpokesmanReward.txt";
        protected Dictionary<int, FB_SpokesmanReward> mData = new Dictionary<int, FB_SpokesmanReward>();
        private List<FB_SpokesmanReward> mListData = new List<FB_SpokesmanReward>();
        public List<FB_SpokesmanReward> ListData
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
        public FB_SpokesmanReward GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_SpokesmanReward);
        }
        public Dictionary<int, FB_SpokesmanReward> GetData()
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
            if (!FB_SpokesmanRewardContainer.FB_SpokesmanRewardContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_SpokesmanRewardContainer.GetRootAsFB_SpokesmanRewardContainer(bb);
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
