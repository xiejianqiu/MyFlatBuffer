using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_LevelSealAddExpRateProvider
    {
        private static FB_LevelSealAddExpRateProvider _Instance;
        public static FB_LevelSealAddExpRateProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_LevelSealAddExpRateProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/LevelSealAddExpRate.txt";
        protected Dictionary<int, FB_LevelSealAddExpRate> mData = new Dictionary<int, FB_LevelSealAddExpRate>();
        private List<FB_LevelSealAddExpRate> mListData = new List<FB_LevelSealAddExpRate>();
        public List<FB_LevelSealAddExpRate> ListData
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
        public FB_LevelSealAddExpRate GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_LevelSealAddExpRate);
        }
        public Dictionary<int, FB_LevelSealAddExpRate> GetData()
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
            if (!FB_LevelSealAddExpRateContainer.FB_LevelSealAddExpRateContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_LevelSealAddExpRateContainer.GetRootAsFB_LevelSealAddExpRateContainer(bb);
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
