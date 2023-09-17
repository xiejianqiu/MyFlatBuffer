using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_LevelCompensateProvider
    {
        private static FB_LevelCompensateProvider _Instance;
        public static FB_LevelCompensateProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_LevelCompensateProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/LevelCompensate.txt";
        protected Dictionary<int, FB_LevelCompensate> mData = new Dictionary<int, FB_LevelCompensate>();
        private List<FB_LevelCompensate> mListData = new List<FB_LevelCompensate>();
        public List<FB_LevelCompensate> ListData
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
        public FB_LevelCompensate GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_LevelCompensate);
        }
        public Dictionary<int, FB_LevelCompensate> GetData()
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
            if (!FB_LevelCompensateContainer.FB_LevelCompensateContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_LevelCompensateContainer.GetRootAsFB_LevelCompensateContainer(bb);
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
