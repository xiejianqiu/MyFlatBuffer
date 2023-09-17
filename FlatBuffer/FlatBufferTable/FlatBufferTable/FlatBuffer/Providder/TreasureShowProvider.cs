using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_TreasureShowProvider
    {
        private static FB_TreasureShowProvider _Instance;
        public static FB_TreasureShowProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_TreasureShowProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/TreasureShow.txt";
        protected Dictionary<int, FB_TreasureShow> mData = new Dictionary<int, FB_TreasureShow>();
        private List<FB_TreasureShow> mListData = new List<FB_TreasureShow>();
        public List<FB_TreasureShow> ListData
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
        public FB_TreasureShow GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_TreasureShow);
        }
        public Dictionary<int, FB_TreasureShow> GetData()
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
            if (!FB_TreasureShowContainer.FB_TreasureShowContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_TreasureShowContainer.GetRootAsFB_TreasureShowContainer(bb);
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
