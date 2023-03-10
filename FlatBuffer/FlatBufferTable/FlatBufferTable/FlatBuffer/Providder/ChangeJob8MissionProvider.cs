using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_ChangeJob8MissionProvider
    {
        private static FB_ChangeJob8MissionProvider _Instance;
        public static FB_ChangeJob8MissionProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_ChangeJob8MissionProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/ChangeJob8Mission.txt";
        protected Dictionary<int, FB_ChangeJob8Mission> mData = new Dictionary<int, FB_ChangeJob8Mission>();
        private List<FB_ChangeJob8Mission> mListData = new List<FB_ChangeJob8Mission>();
        public List<FB_ChangeJob8Mission> ListData
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
        public FB_ChangeJob8Mission GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_ChangeJob8Mission);
        }
        public Dictionary<int, FB_ChangeJob8Mission> GetData()
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
            if (!FB_ChangeJob8MissionContainer.FB_ChangeJob8MissionContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_ChangeJob8MissionContainer.GetRootAsFB_ChangeJob8MissionContainer(bb);
            for (int index = 0; index < data.ItemsLength; index++)
            {
                var item = data.GetItems(index);
                mData.Add(item.MissionId, item);
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
