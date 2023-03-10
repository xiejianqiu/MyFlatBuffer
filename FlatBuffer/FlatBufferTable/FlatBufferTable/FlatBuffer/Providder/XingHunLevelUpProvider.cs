using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_XingHunLevelUpProvider
    {
        private static FB_XingHunLevelUpProvider _Instance;
        public static FB_XingHunLevelUpProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_XingHunLevelUpProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/XingHunLevelUp.txt";
        protected Dictionary<int, FB_XingHunLevelUp> mData = new Dictionary<int, FB_XingHunLevelUp>();
        private List<FB_XingHunLevelUp> mListData = new List<FB_XingHunLevelUp>();
        public List<FB_XingHunLevelUp> ListData
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
        public FB_XingHunLevelUp GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_XingHunLevelUp);
        }
        public Dictionary<int, FB_XingHunLevelUp> GetData()
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
            if (!FB_XingHunLevelUpContainer.FB_XingHunLevelUpContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_XingHunLevelUpContainer.GetRootAsFB_XingHunLevelUpContainer(bb);
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
