using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_XingYunMissionProvider
    {
        private static FB_XingYunMissionProvider _Instance;
        public static FB_XingYunMissionProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_XingYunMissionProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/XingYunMission.txt";
        protected Dictionary<int, FB_XingYunMission> mData = new Dictionary<int, FB_XingYunMission>();
        private List<FB_XingYunMission> mListData = new List<FB_XingYunMission>();
        public List<FB_XingYunMission> ListData
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
        public FB_XingYunMission GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_XingYunMission);
        }
        public Dictionary<int, FB_XingYunMission> GetData()
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
            if (!FB_XingYunMissionContainer.FB_XingYunMissionContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_XingYunMissionContainer.GetRootAsFB_XingYunMissionContainer(bb);
            for (int index = 0; index < data.ItemsLength; index++)
            {
                var item = data.GetItems(index);
                mData.Add(item.MissionID, item);
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
