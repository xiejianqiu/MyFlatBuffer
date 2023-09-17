using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_WitCompeteProvider
    {
        private static FB_WitCompeteProvider _Instance;
        public static FB_WitCompeteProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_WitCompeteProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/WitCompete.txt";
        protected Dictionary<int, FB_WitCompete> mData = new Dictionary<int, FB_WitCompete>();
        private List<FB_WitCompete> mListData = new List<FB_WitCompete>();
        public List<FB_WitCompete> ListData
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
        public FB_WitCompete GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_WitCompete);
        }
        public Dictionary<int, FB_WitCompete> GetData()
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
            if (!FB_WitCompeteContainer.FB_WitCompeteContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_WitCompeteContainer.GetRootAsFB_WitCompeteContainer(bb);
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
