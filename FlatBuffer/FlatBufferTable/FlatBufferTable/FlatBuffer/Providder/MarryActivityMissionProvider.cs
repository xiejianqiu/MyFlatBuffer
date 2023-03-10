using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_MarryActivityMissionProvider
    {
        private static FB_MarryActivityMissionProvider _Instance;
        public static FB_MarryActivityMissionProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_MarryActivityMissionProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/MarryActivityMission.txt";
        protected Dictionary<int, FB_MarryActivityMission> mData = new Dictionary<int, FB_MarryActivityMission>();
        private List<FB_MarryActivityMission> mListData = new List<FB_MarryActivityMission>();
        public List<FB_MarryActivityMission> ListData
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
        public FB_MarryActivityMission GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_MarryActivityMission);
        }
        public Dictionary<int, FB_MarryActivityMission> GetData()
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
            if (!FB_MarryActivityMissionContainer.FB_MarryActivityMissionContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_MarryActivityMissionContainer.GetRootAsFB_MarryActivityMissionContainer(bb);
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
