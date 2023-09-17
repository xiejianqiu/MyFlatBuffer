using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_SYHZaDanPingGuoShowProvider
    {
        private static FB_SYHZaDanPingGuoShowProvider _Instance;
        public static FB_SYHZaDanPingGuoShowProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_SYHZaDanPingGuoShowProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Client/SYHZaDanPingGuoShow.txt";
        protected Dictionary<int, FB_SYHZaDanPingGuoShow> mData = new Dictionary<int, FB_SYHZaDanPingGuoShow>();
        private List<FB_SYHZaDanPingGuoShow> mListData = new List<FB_SYHZaDanPingGuoShow>();
        public List<FB_SYHZaDanPingGuoShow> ListData
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
        public FB_SYHZaDanPingGuoShow GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_SYHZaDanPingGuoShow);
        }
        public Dictionary<int, FB_SYHZaDanPingGuoShow> GetData()
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
            if (!FB_SYHZaDanPingGuoShowContainer.FB_SYHZaDanPingGuoShowContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_SYHZaDanPingGuoShowContainer.GetRootAsFB_SYHZaDanPingGuoShowContainer(bb);
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
