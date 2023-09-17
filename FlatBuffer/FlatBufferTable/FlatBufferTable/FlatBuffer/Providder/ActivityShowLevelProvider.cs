using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_ActivityShowLevelProvider
    {
        private static FB_ActivityShowLevelProvider _Instance;
        public static FB_ActivityShowLevelProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_ActivityShowLevelProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/ActivityShowLevel.txt";
        protected Dictionary<int, FB_ActivityShowLevel> mData = new Dictionary<int, FB_ActivityShowLevel>();
        private List<FB_ActivityShowLevel> mListData = new List<FB_ActivityShowLevel>();
        public List<FB_ActivityShowLevel> ListData
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
        public FB_ActivityShowLevel GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_ActivityShowLevel);
        }
        public Dictionary<int, FB_ActivityShowLevel> GetData()
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
            if (!FB_ActivityShowLevelContainer.FB_ActivityShowLevelContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_ActivityShowLevelContainer.GetRootAsFB_ActivityShowLevelContainer(bb);
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
