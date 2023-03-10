using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_HunJiangJiBanLevelUpProvider
    {
        private static FB_HunJiangJiBanLevelUpProvider _Instance;
        public static FB_HunJiangJiBanLevelUpProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_HunJiangJiBanLevelUpProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/HunJiangJiBanLevelUp.txt";
        protected Dictionary<int, FB_HunJiangJiBanLevelUp> mData = new Dictionary<int, FB_HunJiangJiBanLevelUp>();
        private List<FB_HunJiangJiBanLevelUp> mListData = new List<FB_HunJiangJiBanLevelUp>();
        public List<FB_HunJiangJiBanLevelUp> ListData
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
        public FB_HunJiangJiBanLevelUp GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_HunJiangJiBanLevelUp);
        }
        public Dictionary<int, FB_HunJiangJiBanLevelUp> GetData()
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
            if (!FB_HunJiangJiBanLevelUpContainer.FB_HunJiangJiBanLevelUpContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_HunJiangJiBanLevelUpContainer.GetRootAsFB_HunJiangJiBanLevelUpContainer(bb);
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
