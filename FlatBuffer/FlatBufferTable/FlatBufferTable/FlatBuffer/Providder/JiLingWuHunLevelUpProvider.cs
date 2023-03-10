using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_JiLingWuHunLevelUpProvider
    {
        private static FB_JiLingWuHunLevelUpProvider _Instance;
        public static FB_JiLingWuHunLevelUpProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_JiLingWuHunLevelUpProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/JiLingWuHunLevelUp.txt";
        protected Dictionary<int, FB_JiLingWuHunLevelUp> mData = new Dictionary<int, FB_JiLingWuHunLevelUp>();
        private List<FB_JiLingWuHunLevelUp> mListData = new List<FB_JiLingWuHunLevelUp>();
        public List<FB_JiLingWuHunLevelUp> ListData
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
        public FB_JiLingWuHunLevelUp GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_JiLingWuHunLevelUp);
        }
        public Dictionary<int, FB_JiLingWuHunLevelUp> GetData()
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
            if (!FB_JiLingWuHunLevelUpContainer.FB_JiLingWuHunLevelUpContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_JiLingWuHunLevelUpContainer.GetRootAsFB_JiLingWuHunLevelUpContainer(bb);
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
