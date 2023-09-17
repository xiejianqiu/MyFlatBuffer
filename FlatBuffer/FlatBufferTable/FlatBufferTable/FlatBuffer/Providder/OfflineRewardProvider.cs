using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_OfflineRewardProvider
    {
        private static FB_OfflineRewardProvider _Instance;
        public static FB_OfflineRewardProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_OfflineRewardProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/OfflineReward.txt";
        protected Dictionary<int, FB_OfflineReward> mData = new Dictionary<int, FB_OfflineReward>();
        private List<FB_OfflineReward> mListData = new List<FB_OfflineReward>();
        public List<FB_OfflineReward> ListData
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
        public FB_OfflineReward GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_OfflineReward);
        }
        public Dictionary<int, FB_OfflineReward> GetData()
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
            if (!FB_OfflineRewardContainer.FB_OfflineRewardContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_OfflineRewardContainer.GetRootAsFB_OfflineRewardContainer(bb);
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
