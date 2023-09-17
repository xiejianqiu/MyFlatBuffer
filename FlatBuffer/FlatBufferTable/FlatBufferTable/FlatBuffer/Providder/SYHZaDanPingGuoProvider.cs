using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_SYHZaDanPingGuoProvider
    {
        private static FB_SYHZaDanPingGuoProvider _Instance;
        public static FB_SYHZaDanPingGuoProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_SYHZaDanPingGuoProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/SYHZaDanPingGuo.txt";
        protected Dictionary<int, FB_SYHZaDanPingGuo> mData = new Dictionary<int, FB_SYHZaDanPingGuo>();
        private List<FB_SYHZaDanPingGuo> mListData = new List<FB_SYHZaDanPingGuo>();
        public List<FB_SYHZaDanPingGuo> ListData
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
        public FB_SYHZaDanPingGuo GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_SYHZaDanPingGuo);
        }
        public Dictionary<int, FB_SYHZaDanPingGuo> GetData()
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
            if (!FB_SYHZaDanPingGuoContainer.FB_SYHZaDanPingGuoContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_SYHZaDanPingGuoContainer.GetRootAsFB_SYHZaDanPingGuoContainer(bb);
            for (int index = 0; index < data.ItemsLength; index++)
            {
                var item = data.GetItems(index);
                mData.Add(item.id, item);
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
