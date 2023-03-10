using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_SYHCangBaoMissionProvider
    {
        private static FB_SYHCangBaoMissionProvider _Instance;
        public static FB_SYHCangBaoMissionProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_SYHCangBaoMissionProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/SYHCangBaoMission.txt";
        protected Dictionary<int, FB_SYHCangBaoMission> mData = new Dictionary<int, FB_SYHCangBaoMission>();
        private List<FB_SYHCangBaoMission> mListData = new List<FB_SYHCangBaoMission>();
        public List<FB_SYHCangBaoMission> ListData
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
        public FB_SYHCangBaoMission GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_SYHCangBaoMission);
        }
        public Dictionary<int, FB_SYHCangBaoMission> GetData()
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
            if (!FB_SYHCangBaoMissionContainer.FB_SYHCangBaoMissionContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_SYHCangBaoMissionContainer.GetRootAsFB_SYHCangBaoMissionContainer(bb);
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
