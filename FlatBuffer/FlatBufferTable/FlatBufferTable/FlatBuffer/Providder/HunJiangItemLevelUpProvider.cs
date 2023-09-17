using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_HunJiangItemLevelUpProvider
    {
        private static FB_HunJiangItemLevelUpProvider _Instance;
        public static FB_HunJiangItemLevelUpProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_HunJiangItemLevelUpProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/HunJiangItemLevelUp.txt";
        protected Dictionary<int, FB_HunJiangItemLevelUp> mData = new Dictionary<int, FB_HunJiangItemLevelUp>();
        private List<FB_HunJiangItemLevelUp> mListData = new List<FB_HunJiangItemLevelUp>();
        public List<FB_HunJiangItemLevelUp> ListData
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
        public FB_HunJiangItemLevelUp GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_HunJiangItemLevelUp);
        }
        public Dictionary<int, FB_HunJiangItemLevelUp> GetData()
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
            if (!FB_HunJiangItemLevelUpContainer.FB_HunJiangItemLevelUpContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_HunJiangItemLevelUpContainer.GetRootAsFB_HunJiangItemLevelUpContainer(bb);
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
