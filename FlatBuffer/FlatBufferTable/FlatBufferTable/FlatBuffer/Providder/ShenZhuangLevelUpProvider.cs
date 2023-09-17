using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_ShenZhuangLevelUpProvider
    {
        private static FB_ShenZhuangLevelUpProvider _Instance;
        public static FB_ShenZhuangLevelUpProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_ShenZhuangLevelUpProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/ShenZhuangLevelUp.txt";
        protected Dictionary<int, FB_ShenZhuangLevelUp> mData = new Dictionary<int, FB_ShenZhuangLevelUp>();
        private List<FB_ShenZhuangLevelUp> mListData = new List<FB_ShenZhuangLevelUp>();
        public List<FB_ShenZhuangLevelUp> ListData
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
        public FB_ShenZhuangLevelUp GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_ShenZhuangLevelUp);
        }
        public Dictionary<int, FB_ShenZhuangLevelUp> GetData()
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
            if (!FB_ShenZhuangLevelUpContainer.FB_ShenZhuangLevelUpContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_ShenZhuangLevelUpContainer.GetRootAsFB_ShenZhuangLevelUpContainer(bb);
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
