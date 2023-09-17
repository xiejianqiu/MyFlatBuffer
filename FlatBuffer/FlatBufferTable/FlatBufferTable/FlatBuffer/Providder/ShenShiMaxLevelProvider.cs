using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_ShenShiMaxLevelProvider
    {
        private static FB_ShenShiMaxLevelProvider _Instance;
        public static FB_ShenShiMaxLevelProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_ShenShiMaxLevelProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/ShenShiMaxLevel.txt";
        protected Dictionary<int, FB_ShenShiMaxLevel> mData = new Dictionary<int, FB_ShenShiMaxLevel>();
        private List<FB_ShenShiMaxLevel> mListData = new List<FB_ShenShiMaxLevel>();
        public List<FB_ShenShiMaxLevel> ListData
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
        public FB_ShenShiMaxLevel GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_ShenShiMaxLevel);
        }
        public Dictionary<int, FB_ShenShiMaxLevel> GetData()
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
            if (!FB_ShenShiMaxLevelContainer.FB_ShenShiMaxLevelContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_ShenShiMaxLevelContainer.GetRootAsFB_ShenShiMaxLevelContainer(bb);
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
