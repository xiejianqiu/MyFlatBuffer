using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_JiLingQiLingLevelUpProvider
    {
        private static FB_JiLingQiLingLevelUpProvider _Instance;
        public static FB_JiLingQiLingLevelUpProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_JiLingQiLingLevelUpProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/JiLingQiLingLevelUp.txt";
        protected Dictionary<int, FB_JiLingQiLingLevelUp> mData = new Dictionary<int, FB_JiLingQiLingLevelUp>();
        private List<FB_JiLingQiLingLevelUp> mListData = new List<FB_JiLingQiLingLevelUp>();
        public List<FB_JiLingQiLingLevelUp> ListData
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
        public FB_JiLingQiLingLevelUp GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_JiLingQiLingLevelUp);
        }
        public Dictionary<int, FB_JiLingQiLingLevelUp> GetData()
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
            if (!FB_JiLingQiLingLevelUpContainer.FB_JiLingQiLingLevelUpContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_JiLingQiLingLevelUpContainer.GetRootAsFB_JiLingQiLingLevelUpContainer(bb);
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
