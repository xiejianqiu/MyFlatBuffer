using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_ActivityObjectivesListProvider
    {
        private static FB_ActivityObjectivesListProvider _Instance;
        public static FB_ActivityObjectivesListProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_ActivityObjectivesListProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/ActivityObjectivesList.txt";
        protected Dictionary<int, FB_ActivityObjectivesList> mData = new Dictionary<int, FB_ActivityObjectivesList>();
        private List<FB_ActivityObjectivesList> mListData = new List<FB_ActivityObjectivesList>();
        public List<FB_ActivityObjectivesList> ListData
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
        public FB_ActivityObjectivesList GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_ActivityObjectivesList);
        }
        public Dictionary<int, FB_ActivityObjectivesList> GetData()
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
            if (!FB_ActivityObjectivesListContainer.FB_ActivityObjectivesListContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_ActivityObjectivesListContainer.GetRootAsFB_ActivityObjectivesListContainer(bb);
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
