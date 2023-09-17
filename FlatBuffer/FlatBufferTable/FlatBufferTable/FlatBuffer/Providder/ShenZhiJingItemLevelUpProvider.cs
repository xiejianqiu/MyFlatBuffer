using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_ShenZhiJingItemLevelUpProvider
    {
        private static FB_ShenZhiJingItemLevelUpProvider _Instance;
        public static FB_ShenZhiJingItemLevelUpProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_ShenZhiJingItemLevelUpProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/ShenZhiJingItemLevelUp.txt";
        protected Dictionary<int, FB_ShenZhiJingItemLevelUp> mData = new Dictionary<int, FB_ShenZhiJingItemLevelUp>();
        private List<FB_ShenZhiJingItemLevelUp> mListData = new List<FB_ShenZhiJingItemLevelUp>();
        public List<FB_ShenZhiJingItemLevelUp> ListData
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
        public FB_ShenZhiJingItemLevelUp GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_ShenZhiJingItemLevelUp);
        }
        public Dictionary<int, FB_ShenZhiJingItemLevelUp> GetData()
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
            if (!FB_ShenZhiJingItemLevelUpContainer.FB_ShenZhiJingItemLevelUpContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_ShenZhiJingItemLevelUpContainer.GetRootAsFB_ShenZhiJingItemLevelUpContainer(bb);
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
