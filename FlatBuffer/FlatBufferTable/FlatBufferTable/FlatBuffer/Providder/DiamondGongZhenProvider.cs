using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_DiamondGongZhenProvider
    {
        private static FB_DiamondGongZhenProvider _Instance;
        public static FB_DiamondGongZhenProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_DiamondGongZhenProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/DiamondGongZhen.txt";
        protected Dictionary<int, FB_DiamondGongZhen> mData = new Dictionary<int, FB_DiamondGongZhen>();
        private List<FB_DiamondGongZhen> mListData = new List<FB_DiamondGongZhen>();
        public List<FB_DiamondGongZhen> ListData
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
        public FB_DiamondGongZhen GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_DiamondGongZhen);
        }
        public Dictionary<int, FB_DiamondGongZhen> GetData()
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
            if (!FB_DiamondGongZhenContainer.FB_DiamondGongZhenContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_DiamondGongZhenContainer.GetRootAsFB_DiamondGongZhenContainer(bb);
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
