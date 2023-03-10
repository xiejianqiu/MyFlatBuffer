using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_XianYuZhiYiUnlockLevelUpProvider
    {
        private static FB_XianYuZhiYiUnlockLevelUpProvider _Instance;
        public static FB_XianYuZhiYiUnlockLevelUpProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_XianYuZhiYiUnlockLevelUpProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/XianYuZhiYiUnlockLevelUp.txt";
        protected Dictionary<int, FB_XianYuZhiYiUnlockLevelUp> mData = new Dictionary<int, FB_XianYuZhiYiUnlockLevelUp>();
        private List<FB_XianYuZhiYiUnlockLevelUp> mListData = new List<FB_XianYuZhiYiUnlockLevelUp>();
        public List<FB_XianYuZhiYiUnlockLevelUp> ListData
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
        public FB_XianYuZhiYiUnlockLevelUp GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_XianYuZhiYiUnlockLevelUp);
        }
        public Dictionary<int, FB_XianYuZhiYiUnlockLevelUp> GetData()
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
            if (!FB_XianYuZhiYiUnlockLevelUpContainer.FB_XianYuZhiYiUnlockLevelUpContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_XianYuZhiYiUnlockLevelUpContainer.GetRootAsFB_XianYuZhiYiUnlockLevelUpContainer(bb);
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
