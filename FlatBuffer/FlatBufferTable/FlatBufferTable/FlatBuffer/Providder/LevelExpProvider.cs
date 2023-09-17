using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_LevelExpProvider
    {
        private static FB_LevelExpProvider _Instance;
        public static FB_LevelExpProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_LevelExpProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/LevelExp.txt";
        protected Dictionary<int, FB_LevelExp> mData = new Dictionary<int, FB_LevelExp>();
        private List<FB_LevelExp> mListData = new List<FB_LevelExp>();
        public List<FB_LevelExp> ListData
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
        public FB_LevelExp GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_LevelExp);
        }
        public Dictionary<int, FB_LevelExp> GetData()
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
            if (!FB_LevelExpContainer.FB_LevelExpContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_LevelExpContainer.GetRootAsFB_LevelExpContainer(bb);
            for (int index = 0; index < data.ItemsLength; index++)
            {
                var item = data.GetItems(index);
                mData.Add(item.LevelID, item);
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
