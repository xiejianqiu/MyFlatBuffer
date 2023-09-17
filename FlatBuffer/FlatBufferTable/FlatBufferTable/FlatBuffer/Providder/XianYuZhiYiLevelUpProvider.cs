using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_XianYuZhiYiLevelUpProvider
    {
        private static FB_XianYuZhiYiLevelUpProvider _Instance;
        public static FB_XianYuZhiYiLevelUpProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_XianYuZhiYiLevelUpProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/XianYuZhiYiLevelUp.txt";
        protected Dictionary<int, FB_XianYuZhiYiLevelUp> mData = new Dictionary<int, FB_XianYuZhiYiLevelUp>();
        private List<FB_XianYuZhiYiLevelUp> mListData = new List<FB_XianYuZhiYiLevelUp>();
        public List<FB_XianYuZhiYiLevelUp> ListData
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
        public FB_XianYuZhiYiLevelUp GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_XianYuZhiYiLevelUp);
        }
        public Dictionary<int, FB_XianYuZhiYiLevelUp> GetData()
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
            if (!FB_XianYuZhiYiLevelUpContainer.FB_XianYuZhiYiLevelUpContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_XianYuZhiYiLevelUpContainer.GetRootAsFB_XianYuZhiYiLevelUpContainer(bb);
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
