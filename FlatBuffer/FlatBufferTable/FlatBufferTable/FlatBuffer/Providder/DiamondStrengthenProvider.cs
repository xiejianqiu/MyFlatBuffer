using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_DiamondStrengthenProvider
    {
        private static FB_DiamondStrengthenProvider _Instance;
        public static FB_DiamondStrengthenProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_DiamondStrengthenProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/DiamondStrengthen.txt";
        protected Dictionary<int, FB_DiamondStrengthen> mData = new Dictionary<int, FB_DiamondStrengthen>();
        private List<FB_DiamondStrengthen> mListData = new List<FB_DiamondStrengthen>();
        public List<FB_DiamondStrengthen> ListData
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
        public FB_DiamondStrengthen GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_DiamondStrengthen);
        }
        public Dictionary<int, FB_DiamondStrengthen> GetData()
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
            if (!FB_DiamondStrengthenContainer.FB_DiamondStrengthenContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_DiamondStrengthenContainer.GetRootAsFB_DiamondStrengthenContainer(bb);
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
