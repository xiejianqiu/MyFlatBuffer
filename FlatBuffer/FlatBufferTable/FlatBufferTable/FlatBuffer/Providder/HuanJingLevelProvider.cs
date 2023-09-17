using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_HuanJingLevelProvider
    {
        private static FB_HuanJingLevelProvider _Instance;
        public static FB_HuanJingLevelProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_HuanJingLevelProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/HuanJingLevel.txt";
        protected Dictionary<int, FB_HuanJingLevel> mData = new Dictionary<int, FB_HuanJingLevel>();
        private List<FB_HuanJingLevel> mListData = new List<FB_HuanJingLevel>();
        public List<FB_HuanJingLevel> ListData
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
        public FB_HuanJingLevel GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_HuanJingLevel);
        }
        public Dictionary<int, FB_HuanJingLevel> GetData()
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
            if (!FB_HuanJingLevelContainer.FB_HuanJingLevelContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_HuanJingLevelContainer.GetRootAsFB_HuanJingLevelContainer(bb);
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
