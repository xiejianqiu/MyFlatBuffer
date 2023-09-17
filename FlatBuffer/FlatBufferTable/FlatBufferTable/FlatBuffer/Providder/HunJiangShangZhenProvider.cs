using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_HunJiangShangZhenProvider
    {
        private static FB_HunJiangShangZhenProvider _Instance;
        public static FB_HunJiangShangZhenProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_HunJiangShangZhenProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/HunJiangShangZhen.txt";
        protected Dictionary<int, FB_HunJiangShangZhen> mData = new Dictionary<int, FB_HunJiangShangZhen>();
        private List<FB_HunJiangShangZhen> mListData = new List<FB_HunJiangShangZhen>();
        public List<FB_HunJiangShangZhen> ListData
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
        public FB_HunJiangShangZhen GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_HunJiangShangZhen);
        }
        public Dictionary<int, FB_HunJiangShangZhen> GetData()
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
            if (!FB_HunJiangShangZhenContainer.FB_HunJiangShangZhenContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_HunJiangShangZhenContainer.GetRootAsFB_HunJiangShangZhenContainer(bb);
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
