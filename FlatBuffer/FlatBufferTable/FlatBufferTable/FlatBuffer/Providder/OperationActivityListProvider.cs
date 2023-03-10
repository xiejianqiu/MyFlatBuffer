using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_OperationActivityListProvider
    {
        private static FB_OperationActivityListProvider _Instance;
        public static FB_OperationActivityListProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_OperationActivityListProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/OperationActivityList.txt";
        protected Dictionary<int, FB_OperationActivityList> mData = new Dictionary<int, FB_OperationActivityList>();
        private List<FB_OperationActivityList> mListData = new List<FB_OperationActivityList>();
        public List<FB_OperationActivityList> ListData
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
        public FB_OperationActivityList GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_OperationActivityList);
        }
        public Dictionary<int, FB_OperationActivityList> GetData()
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
            if (!FB_OperationActivityListContainer.FB_OperationActivityListContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_OperationActivityListContainer.GetRootAsFB_OperationActivityListContainer(bb);
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
