using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_JiLingDestinyLevelUpProvider
    {
        private static FB_JiLingDestinyLevelUpProvider _Instance;
        public static FB_JiLingDestinyLevelUpProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_JiLingDestinyLevelUpProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/JiLingDestinyLevelUp.txt";
        protected Dictionary<int, FB_JiLingDestinyLevelUp> mData = new Dictionary<int, FB_JiLingDestinyLevelUp>();
        private List<FB_JiLingDestinyLevelUp> mListData = new List<FB_JiLingDestinyLevelUp>();
        public List<FB_JiLingDestinyLevelUp> ListData
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
        public FB_JiLingDestinyLevelUp GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_JiLingDestinyLevelUp);
        }
        public Dictionary<int, FB_JiLingDestinyLevelUp> GetData()
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
            if (!FB_JiLingDestinyLevelUpContainer.FB_JiLingDestinyLevelUpContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_JiLingDestinyLevelUpContainer.GetRootAsFB_JiLingDestinyLevelUpContainer(bb);
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
