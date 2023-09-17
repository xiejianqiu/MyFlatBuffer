using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_MiniMapProvider
    {
        private static FB_MiniMapProvider _Instance;
        public static FB_MiniMapProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_MiniMapProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/MiniMap.txt";
        protected Dictionary<int, FB_MiniMap> mData = new Dictionary<int, FB_MiniMap>();
        private List<FB_MiniMap> mListData = new List<FB_MiniMap>();
        public List<FB_MiniMap> ListData
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
        public FB_MiniMap GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_MiniMap);
        }
        public Dictionary<int, FB_MiniMap> GetData()
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
            if (!FB_MiniMapContainer.FB_MiniMapContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_MiniMapContainer.GetRootAsFB_MiniMapContainer(bb);
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
