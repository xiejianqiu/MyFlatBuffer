using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_CSQXuanSNpcProvider
    {
        private static FB_CSQXuanSNpcProvider _Instance;
        public static FB_CSQXuanSNpcProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_CSQXuanSNpcProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Client/CSQXuanSNpc.txt";
        protected Dictionary<int, FB_CSQXuanSNpc> mData = new Dictionary<int, FB_CSQXuanSNpc>();
        private List<FB_CSQXuanSNpc> mListData = new List<FB_CSQXuanSNpc>();
        public List<FB_CSQXuanSNpc> ListData
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
        public FB_CSQXuanSNpc GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_CSQXuanSNpc);
        }
        public Dictionary<int, FB_CSQXuanSNpc> GetData()
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
            if (!FB_CSQXuanSNpcContainer.FB_CSQXuanSNpcContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_CSQXuanSNpcContainer.GetRootAsFB_CSQXuanSNpcContainer(bb);
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
