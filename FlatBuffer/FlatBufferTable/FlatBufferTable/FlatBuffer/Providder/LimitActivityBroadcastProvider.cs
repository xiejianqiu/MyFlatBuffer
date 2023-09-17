using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_LimitActivityBroadcastProvider
    {
        private static FB_LimitActivityBroadcastProvider _Instance;
        public static FB_LimitActivityBroadcastProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_LimitActivityBroadcastProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/LimitActivityBroadcast.txt";
        protected Dictionary<int, FB_LimitActivityBroadcast> mData = new Dictionary<int, FB_LimitActivityBroadcast>();
        private List<FB_LimitActivityBroadcast> mListData = new List<FB_LimitActivityBroadcast>();
        public List<FB_LimitActivityBroadcast> ListData
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
        public FB_LimitActivityBroadcast GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_LimitActivityBroadcast);
        }
        public Dictionary<int, FB_LimitActivityBroadcast> GetData()
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
            if (!FB_LimitActivityBroadcastContainer.FB_LimitActivityBroadcastContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_LimitActivityBroadcastContainer.GetRootAsFB_LimitActivityBroadcastContainer(bb);
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
