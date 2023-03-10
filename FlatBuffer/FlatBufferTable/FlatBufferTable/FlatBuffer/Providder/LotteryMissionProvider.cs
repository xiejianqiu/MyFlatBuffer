using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_LotteryMissionProvider
    {
        private static FB_LotteryMissionProvider _Instance;
        public static FB_LotteryMissionProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_LotteryMissionProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/LotteryMission.txt";
        protected Dictionary<int, FB_LotteryMission> mData = new Dictionary<int, FB_LotteryMission>();
        private List<FB_LotteryMission> mListData = new List<FB_LotteryMission>();
        public List<FB_LotteryMission> ListData
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
        public FB_LotteryMission GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_LotteryMission);
        }
        public Dictionary<int, FB_LotteryMission> GetData()
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
            if (!FB_LotteryMissionContainer.FB_LotteryMissionContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_LotteryMissionContainer.GetRootAsFB_LotteryMissionContainer(bb);
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
