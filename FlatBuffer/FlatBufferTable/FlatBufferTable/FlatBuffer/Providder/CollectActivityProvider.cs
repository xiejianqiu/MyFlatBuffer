using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_CollectActivityProvider
    {
        private static FB_CollectActivityProvider _Instance;
        public static FB_CollectActivityProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_CollectActivityProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/CollectActivity.txt";
        protected Dictionary<int, FB_CollectActivity> mData = new Dictionary<int, FB_CollectActivity>();
        private List<FB_CollectActivity> mListData = new List<FB_CollectActivity>();
        public List<FB_CollectActivity> ListData
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
        public FB_CollectActivity GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_CollectActivity);
        }
        public Dictionary<int, FB_CollectActivity> GetData()
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
            if (!FB_CollectActivityContainer.FB_CollectActivityContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_CollectActivityContainer.GetRootAsFB_CollectActivityContainer(bb);
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
