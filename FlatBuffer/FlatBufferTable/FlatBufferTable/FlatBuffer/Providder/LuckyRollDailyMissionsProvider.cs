using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_LuckyRollDailyMissionsProvider
    {
        private static FB_LuckyRollDailyMissionsProvider _Instance;
        public static FB_LuckyRollDailyMissionsProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_LuckyRollDailyMissionsProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/LuckyRollDailyMissions.txt";
        protected Dictionary<int, FB_LuckyRollDailyMissions> mData = new Dictionary<int, FB_LuckyRollDailyMissions>();
        private List<FB_LuckyRollDailyMissions> mListData = new List<FB_LuckyRollDailyMissions>();
        public List<FB_LuckyRollDailyMissions> ListData
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
        public FB_LuckyRollDailyMissions GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_LuckyRollDailyMissions);
        }
        public Dictionary<int, FB_LuckyRollDailyMissions> GetData()
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
            if (!FB_LuckyRollDailyMissionsContainer.FB_LuckyRollDailyMissionsContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_LuckyRollDailyMissionsContainer.GetRootAsFB_LuckyRollDailyMissionsContainer(bb);
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
