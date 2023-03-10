using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_LingGangLingWuLevelUpProvider
    {
        private static FB_LingGangLingWuLevelUpProvider _Instance;
        public static FB_LingGangLingWuLevelUpProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_LingGangLingWuLevelUpProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/LingGangLingWuLevelUp.txt";
        protected Dictionary<int, FB_LingGangLingWuLevelUp> mData = new Dictionary<int, FB_LingGangLingWuLevelUp>();
        private List<FB_LingGangLingWuLevelUp> mListData = new List<FB_LingGangLingWuLevelUp>();
        public List<FB_LingGangLingWuLevelUp> ListData
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
        public FB_LingGangLingWuLevelUp GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_LingGangLingWuLevelUp);
        }
        public Dictionary<int, FB_LingGangLingWuLevelUp> GetData()
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
            if (!FB_LingGangLingWuLevelUpContainer.FB_LingGangLingWuLevelUpContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_LingGangLingWuLevelUpContainer.GetRootAsFB_LingGangLingWuLevelUpContainer(bb);
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
