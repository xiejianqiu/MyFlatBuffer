using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_PlayMethodBroadcastProvider
    {
        private static FB_PlayMethodBroadcastProvider _Instance;
        public static FB_PlayMethodBroadcastProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_PlayMethodBroadcastProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Client/PlayMethodBroadcast.txt";
        protected Dictionary<int, FB_PlayMethodBroadcast> mData = new Dictionary<int, FB_PlayMethodBroadcast>();
        private List<FB_PlayMethodBroadcast> mListData = new List<FB_PlayMethodBroadcast>();
        public List<FB_PlayMethodBroadcast> ListData
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
        public FB_PlayMethodBroadcast GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_PlayMethodBroadcast);
        }
        public Dictionary<int, FB_PlayMethodBroadcast> GetData()
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
            if (!FB_PlayMethodBroadcastContainer.FB_PlayMethodBroadcastContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_PlayMethodBroadcastContainer.GetRootAsFB_PlayMethodBroadcastContainer(bb);
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
