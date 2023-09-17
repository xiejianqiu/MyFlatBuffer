using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_ActivityChickenMissionProvider
    {
        private static FB_ActivityChickenMissionProvider _Instance;
        public static FB_ActivityChickenMissionProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_ActivityChickenMissionProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/ActivityChickenMission.txt";
        protected Dictionary<int, FB_ActivityChickenMission> mData = new Dictionary<int, FB_ActivityChickenMission>();
        private List<FB_ActivityChickenMission> mListData = new List<FB_ActivityChickenMission>();
        public List<FB_ActivityChickenMission> ListData
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
        public FB_ActivityChickenMission GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_ActivityChickenMission);
        }
        public Dictionary<int, FB_ActivityChickenMission> GetData()
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
            if (!FB_ActivityChickenMissionContainer.FB_ActivityChickenMissionContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_ActivityChickenMissionContainer.GetRootAsFB_ActivityChickenMissionContainer(bb);
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
