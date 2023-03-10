using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_ActivityDaZhiGouRewardProvider
    {
        private static FB_ActivityDaZhiGouRewardProvider _Instance;
        public static FB_ActivityDaZhiGouRewardProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_ActivityDaZhiGouRewardProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/ActivityDaZhiGouReward.txt";
        protected Dictionary<int, FB_ActivityDaZhiGouReward> mData = new Dictionary<int, FB_ActivityDaZhiGouReward>();
        private List<FB_ActivityDaZhiGouReward> mListData = new List<FB_ActivityDaZhiGouReward>();
        public List<FB_ActivityDaZhiGouReward> ListData
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
        public FB_ActivityDaZhiGouReward GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_ActivityDaZhiGouReward);
        }
        public Dictionary<int, FB_ActivityDaZhiGouReward> GetData()
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
            if (!FB_ActivityDaZhiGouRewardContainer.FB_ActivityDaZhiGouRewardContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_ActivityDaZhiGouRewardContainer.GetRootAsFB_ActivityDaZhiGouRewardContainer(bb);
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
