using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_ChatLimitProvider
    {
        private static FB_ChatLimitProvider _Instance;
        public static FB_ChatLimitProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_ChatLimitProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/ChatLimit.txt";
        protected Dictionary<int, FB_ChatLimit> mData = new Dictionary<int, FB_ChatLimit>();
        private List<FB_ChatLimit> mListData = new List<FB_ChatLimit>();
        public List<FB_ChatLimit> ListData
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
        public FB_ChatLimit GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_ChatLimit);
        }
        public Dictionary<int, FB_ChatLimit> GetData()
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
            if (!FB_ChatLimitContainer.FB_ChatLimitContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_ChatLimitContainer.GetRootAsFB_ChatLimitContainer(bb);
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
