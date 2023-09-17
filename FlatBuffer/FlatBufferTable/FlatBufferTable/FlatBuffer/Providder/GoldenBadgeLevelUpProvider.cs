using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_GoldenBadgeLevelUpProvider
    {
        private static FB_GoldenBadgeLevelUpProvider _Instance;
        public static FB_GoldenBadgeLevelUpProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_GoldenBadgeLevelUpProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/GoldenBadgeLevelUp.txt";
        protected Dictionary<int, FB_GoldenBadgeLevelUp> mData = new Dictionary<int, FB_GoldenBadgeLevelUp>();
        private List<FB_GoldenBadgeLevelUp> mListData = new List<FB_GoldenBadgeLevelUp>();
        public List<FB_GoldenBadgeLevelUp> ListData
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
        public FB_GoldenBadgeLevelUp GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_GoldenBadgeLevelUp);
        }
        public Dictionary<int, FB_GoldenBadgeLevelUp> GetData()
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
            if (!FB_GoldenBadgeLevelUpContainer.FB_GoldenBadgeLevelUpContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_GoldenBadgeLevelUpContainer.GetRootAsFB_GoldenBadgeLevelUpContainer(bb);
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
