using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_MissionLimitProvider
    {
        private static FB_MissionLimitProvider _Instance;
        public static FB_MissionLimitProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_MissionLimitProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/MissionLimit.txt";
        protected Dictionary<int, FB_MissionLimit> mData = new Dictionary<int, FB_MissionLimit>();
        private List<FB_MissionLimit> mListData = new List<FB_MissionLimit>();
        public List<FB_MissionLimit> ListData
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
        public FB_MissionLimit GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_MissionLimit);
        }
        public Dictionary<int, FB_MissionLimit> GetData()
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
            if (!FB_MissionLimitContainer.FB_MissionLimitContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_MissionLimitContainer.GetRootAsFB_MissionLimitContainer(bb);
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
