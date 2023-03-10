using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_TreasureHuntMissionsProvider
    {
        private static FB_TreasureHuntMissionsProvider _Instance;
        public static FB_TreasureHuntMissionsProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_TreasureHuntMissionsProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/TreasureHuntMissions.txt";
        protected Dictionary<int, FB_TreasureHuntMissions> mData = new Dictionary<int, FB_TreasureHuntMissions>();
        private List<FB_TreasureHuntMissions> mListData = new List<FB_TreasureHuntMissions>();
        public List<FB_TreasureHuntMissions> ListData
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
        public FB_TreasureHuntMissions GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_TreasureHuntMissions);
        }
        public Dictionary<int, FB_TreasureHuntMissions> GetData()
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
            if (!FB_TreasureHuntMissionsContainer.FB_TreasureHuntMissionsContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_TreasureHuntMissionsContainer.GetRootAsFB_TreasureHuntMissionsContainer(bb);
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
