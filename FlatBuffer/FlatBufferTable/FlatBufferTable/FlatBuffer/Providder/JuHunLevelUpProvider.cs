using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_JuHunLevelUpProvider
    {
        private static FB_JuHunLevelUpProvider _Instance;
        public static FB_JuHunLevelUpProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_JuHunLevelUpProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/JuHunLevelUp.txt";
        protected Dictionary<int, FB_JuHunLevelUp> mData = new Dictionary<int, FB_JuHunLevelUp>();
        private List<FB_JuHunLevelUp> mListData = new List<FB_JuHunLevelUp>();
        public List<FB_JuHunLevelUp> ListData
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
        public FB_JuHunLevelUp GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_JuHunLevelUp);
        }
        public Dictionary<int, FB_JuHunLevelUp> GetData()
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
            if (!FB_JuHunLevelUpContainer.FB_JuHunLevelUpContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_JuHunLevelUpContainer.GetRootAsFB_JuHunLevelUpContainer(bb);
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
