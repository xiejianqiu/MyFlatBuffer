using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_StarCraftMapProvider
    {
        private static FB_StarCraftMapProvider _Instance;
        public static FB_StarCraftMapProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_StarCraftMapProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/StarCraftMap.txt";
        protected Dictionary<int, FB_StarCraftMap> mData = new Dictionary<int, FB_StarCraftMap>();
        private List<FB_StarCraftMap> mListData = new List<FB_StarCraftMap>();
        public List<FB_StarCraftMap> ListData
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
        public FB_StarCraftMap GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_StarCraftMap);
        }
        public Dictionary<int, FB_StarCraftMap> GetData()
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
            if (!FB_StarCraftMapContainer.FB_StarCraftMapContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_StarCraftMapContainer.GetRootAsFB_StarCraftMapContainer(bb);
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
