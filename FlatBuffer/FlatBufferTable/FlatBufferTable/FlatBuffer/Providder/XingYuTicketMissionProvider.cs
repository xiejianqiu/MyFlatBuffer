using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_XingYuTicketMissionProvider
    {
        private static FB_XingYuTicketMissionProvider _Instance;
        public static FB_XingYuTicketMissionProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_XingYuTicketMissionProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/XingYuTicketMission.txt";
        protected Dictionary<int, FB_XingYuTicketMission> mData = new Dictionary<int, FB_XingYuTicketMission>();
        private List<FB_XingYuTicketMission> mListData = new List<FB_XingYuTicketMission>();
        public List<FB_XingYuTicketMission> ListData
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
        public FB_XingYuTicketMission GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_XingYuTicketMission);
        }
        public Dictionary<int, FB_XingYuTicketMission> GetData()
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
            if (!FB_XingYuTicketMissionContainer.FB_XingYuTicketMissionContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_XingYuTicketMissionContainer.GetRootAsFB_XingYuTicketMissionContainer(bb);
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
