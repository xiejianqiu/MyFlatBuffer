using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_ChapterCardLevelUpProvider
    {
        private static FB_ChapterCardLevelUpProvider _Instance;
        public static FB_ChapterCardLevelUpProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_ChapterCardLevelUpProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/ChapterCardLevelUp.txt";
        protected Dictionary<int, FB_ChapterCardLevelUp> mData = new Dictionary<int, FB_ChapterCardLevelUp>();
        private List<FB_ChapterCardLevelUp> mListData = new List<FB_ChapterCardLevelUp>();
        public List<FB_ChapterCardLevelUp> ListData
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
        public FB_ChapterCardLevelUp GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_ChapterCardLevelUp);
        }
        public Dictionary<int, FB_ChapterCardLevelUp> GetData()
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
            if (!FB_ChapterCardLevelUpContainer.FB_ChapterCardLevelUpContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_ChapterCardLevelUpContainer.GetRootAsFB_ChapterCardLevelUpContainer(bb);
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
