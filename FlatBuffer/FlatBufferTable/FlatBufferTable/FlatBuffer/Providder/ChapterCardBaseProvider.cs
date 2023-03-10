using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_ChapterCardBaseProvider
    {
        private static FB_ChapterCardBaseProvider _Instance;
        public static FB_ChapterCardBaseProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_ChapterCardBaseProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/ChapterCardBase.txt";
        protected Dictionary<int, FB_ChapterCardBase> mData = new Dictionary<int, FB_ChapterCardBase>();
        private List<FB_ChapterCardBase> mListData = new List<FB_ChapterCardBase>();
        public List<FB_ChapterCardBase> ListData
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
        public FB_ChapterCardBase GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_ChapterCardBase);
        }
        public Dictionary<int, FB_ChapterCardBase> GetData()
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
            if (!FB_ChapterCardBaseContainer.FB_ChapterCardBaseContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_ChapterCardBaseContainer.GetRootAsFB_ChapterCardBaseContainer(bb);
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
