using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_JieYuanLevelUpProvider
    {
        private static FB_JieYuanLevelUpProvider _Instance;
        public static FB_JieYuanLevelUpProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_JieYuanLevelUpProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/JieYuanLevelUp.txt";
        protected Dictionary<int, FB_JieYuanLevelUp> mData = new Dictionary<int, FB_JieYuanLevelUp>();
        private List<FB_JieYuanLevelUp> mListData = new List<FB_JieYuanLevelUp>();
        public List<FB_JieYuanLevelUp> ListData
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
        public FB_JieYuanLevelUp GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_JieYuanLevelUp);
        }
        public Dictionary<int, FB_JieYuanLevelUp> GetData()
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
            if (!FB_JieYuanLevelUpContainer.FB_JieYuanLevelUpContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_JieYuanLevelUpContainer.GetRootAsFB_JieYuanLevelUpContainer(bb);
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
