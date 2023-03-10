using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_TianCiHongFuRewardProvider
    {
        private static FB_TianCiHongFuRewardProvider _Instance;
        public static FB_TianCiHongFuRewardProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_TianCiHongFuRewardProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/TianCiHongFuReward.txt";
        protected Dictionary<int, FB_TianCiHongFuReward> mData = new Dictionary<int, FB_TianCiHongFuReward>();
        private List<FB_TianCiHongFuReward> mListData = new List<FB_TianCiHongFuReward>();
        public List<FB_TianCiHongFuReward> ListData
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
        public FB_TianCiHongFuReward GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_TianCiHongFuReward);
        }
        public Dictionary<int, FB_TianCiHongFuReward> GetData()
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
            if (!FB_TianCiHongFuRewardContainer.FB_TianCiHongFuRewardContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_TianCiHongFuRewardContainer.GetRootAsFB_TianCiHongFuRewardContainer(bb);
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
