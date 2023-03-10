using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_MarryActivityMissionRewardProvider
    {
        private static FB_MarryActivityMissionRewardProvider _Instance;
        public static FB_MarryActivityMissionRewardProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_MarryActivityMissionRewardProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/MarryActivityMissionReward.txt";
        protected Dictionary<int, FB_MarryActivityMissionReward> mData = new Dictionary<int, FB_MarryActivityMissionReward>();
        private List<FB_MarryActivityMissionReward> mListData = new List<FB_MarryActivityMissionReward>();
        public List<FB_MarryActivityMissionReward> ListData
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
        public FB_MarryActivityMissionReward GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_MarryActivityMissionReward);
        }
        public Dictionary<int, FB_MarryActivityMissionReward> GetData()
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
            if (!FB_MarryActivityMissionRewardContainer.FB_MarryActivityMissionRewardContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_MarryActivityMissionRewardContainer.GetRootAsFB_MarryActivityMissionRewardContainer(bb);
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
