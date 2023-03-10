using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_SYHFestivalCarnivalMissionProvider
    {
        private static FB_SYHFestivalCarnivalMissionProvider _Instance;
        public static FB_SYHFestivalCarnivalMissionProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_SYHFestivalCarnivalMissionProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/SYHFestivalCarnivalMission.txt";
        protected Dictionary<int, FB_SYHFestivalCarnivalMission> mData = new Dictionary<int, FB_SYHFestivalCarnivalMission>();
        private List<FB_SYHFestivalCarnivalMission> mListData = new List<FB_SYHFestivalCarnivalMission>();
        public List<FB_SYHFestivalCarnivalMission> ListData
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
        public FB_SYHFestivalCarnivalMission GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_SYHFestivalCarnivalMission);
        }
        public Dictionary<int, FB_SYHFestivalCarnivalMission> GetData()
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
            if (!FB_SYHFestivalCarnivalMissionContainer.FB_SYHFestivalCarnivalMissionContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_SYHFestivalCarnivalMissionContainer.GetRootAsFB_SYHFestivalCarnivalMissionContainer(bb);
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
