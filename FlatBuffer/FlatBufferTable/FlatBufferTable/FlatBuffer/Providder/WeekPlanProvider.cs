using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_WeekPlanProvider
    {
        private static FB_WeekPlanProvider _Instance;
        public static FB_WeekPlanProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_WeekPlanProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Client/WeekPlan.txt";
        protected Dictionary<int, FB_WeekPlan> mData = new Dictionary<int, FB_WeekPlan>();
        private List<FB_WeekPlan> mListData = new List<FB_WeekPlan>();
        public List<FB_WeekPlan> ListData
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
        public FB_WeekPlan GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_WeekPlan);
        }
        public Dictionary<int, FB_WeekPlan> GetData()
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
            if (!FB_WeekPlanContainer.FB_WeekPlanContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_WeekPlanContainer.GetRootAsFB_WeekPlanContainer(bb);
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
