using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_SevenStartBaseLevelUpProvider
    {
        private static FB_SevenStartBaseLevelUpProvider _Instance;
        public static FB_SevenStartBaseLevelUpProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_SevenStartBaseLevelUpProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/SevenStartBaseLevelUp.txt";
        protected Dictionary<int, FB_SevenStartBaseLevelUp> mData = new Dictionary<int, FB_SevenStartBaseLevelUp>();
        private List<FB_SevenStartBaseLevelUp> mListData = new List<FB_SevenStartBaseLevelUp>();
        public List<FB_SevenStartBaseLevelUp> ListData
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
        public FB_SevenStartBaseLevelUp GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_SevenStartBaseLevelUp);
        }
        public Dictionary<int, FB_SevenStartBaseLevelUp> GetData()
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
            if (!FB_SevenStartBaseLevelUpContainer.FB_SevenStartBaseLevelUpContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_SevenStartBaseLevelUpContainer.GetRootAsFB_SevenStartBaseLevelUpContainer(bb);
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
