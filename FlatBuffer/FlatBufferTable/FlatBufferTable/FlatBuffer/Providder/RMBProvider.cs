using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_RMBProvider
    {
        private static FB_RMBProvider _Instance;
        public static FB_RMBProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_RMBProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/RMB.txt";
        protected Dictionary<int, FB_RMB> mData = new Dictionary<int, FB_RMB>();
        private List<FB_RMB> mListData = new List<FB_RMB>();
        public List<FB_RMB> ListData
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
        public FB_RMB GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_RMB);
        }
        public Dictionary<int, FB_RMB> GetData()
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
            if (!FB_RMBContainer.FB_RMBContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_RMBContainer.GetRootAsFB_RMBContainer(bb);
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
