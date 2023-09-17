using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_OppoRewardProvider
    {
        private static FB_OppoRewardProvider _Instance;
        public static FB_OppoRewardProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_OppoRewardProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/OppoReward.txt";
        protected Dictionary<int, FB_OppoReward> mData = new Dictionary<int, FB_OppoReward>();
        private List<FB_OppoReward> mListData = new List<FB_OppoReward>();
        public List<FB_OppoReward> ListData
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
        public FB_OppoReward GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_OppoReward);
        }
        public Dictionary<int, FB_OppoReward> GetData()
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
            if (!FB_OppoRewardContainer.FB_OppoRewardContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_OppoRewardContainer.GetRootAsFB_OppoRewardContainer(bb);
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
