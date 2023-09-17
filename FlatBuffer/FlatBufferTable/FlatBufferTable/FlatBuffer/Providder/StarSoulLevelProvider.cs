using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_StarSoulLevelProvider
    {
        private static FB_StarSoulLevelProvider _Instance;
        public static FB_StarSoulLevelProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_StarSoulLevelProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/StarSoulLevel.txt";
        protected Dictionary<int, FB_StarSoulLevel> mData = new Dictionary<int, FB_StarSoulLevel>();
        private List<FB_StarSoulLevel> mListData = new List<FB_StarSoulLevel>();
        public List<FB_StarSoulLevel> ListData
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
        public FB_StarSoulLevel GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_StarSoulLevel);
        }
        public Dictionary<int, FB_StarSoulLevel> GetData()
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
            if (!FB_StarSoulLevelContainer.FB_StarSoulLevelContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_StarSoulLevelContainer.GetRootAsFB_StarSoulLevelContainer(bb);
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
