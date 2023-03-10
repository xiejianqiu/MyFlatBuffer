using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_LevelSealBaseProvider
    {
        private static FB_LevelSealBaseProvider _Instance;
        public static FB_LevelSealBaseProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_LevelSealBaseProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/LevelSealBase.txt";
        protected Dictionary<int, FB_LevelSealBase> mData = new Dictionary<int, FB_LevelSealBase>();
        private List<FB_LevelSealBase> mListData = new List<FB_LevelSealBase>();
        public List<FB_LevelSealBase> ListData
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
        public FB_LevelSealBase GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_LevelSealBase);
        }
        public Dictionary<int, FB_LevelSealBase> GetData()
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
            if (!FB_LevelSealBaseContainer.FB_LevelSealBaseContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_LevelSealBaseContainer.GetRootAsFB_LevelSealBaseContainer(bb);
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
