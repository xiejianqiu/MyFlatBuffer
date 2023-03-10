using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_MissionFailedConditionProvider
    {
        private static FB_MissionFailedConditionProvider _Instance;
        public static FB_MissionFailedConditionProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_MissionFailedConditionProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/MissionFailedCondition.txt";
        protected Dictionary<int, FB_MissionFailedCondition> mData = new Dictionary<int, FB_MissionFailedCondition>();
        private List<FB_MissionFailedCondition> mListData = new List<FB_MissionFailedCondition>();
        public List<FB_MissionFailedCondition> ListData
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
        public FB_MissionFailedCondition GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_MissionFailedCondition);
        }
        public Dictionary<int, FB_MissionFailedCondition> GetData()
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
            if (!FB_MissionFailedConditionContainer.FB_MissionFailedConditionContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_MissionFailedConditionContainer.GetRootAsFB_MissionFailedConditionContainer(bb);
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
