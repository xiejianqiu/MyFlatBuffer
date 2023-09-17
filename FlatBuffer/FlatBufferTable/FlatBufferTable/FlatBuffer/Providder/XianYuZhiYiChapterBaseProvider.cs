using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_XianYuZhiYiChapterBaseProvider
    {
        private static FB_XianYuZhiYiChapterBaseProvider _Instance;
        public static FB_XianYuZhiYiChapterBaseProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_XianYuZhiYiChapterBaseProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/XianYuZhiYiChapterBase.txt";
        protected Dictionary<int, FB_XianYuZhiYiChapterBase> mData = new Dictionary<int, FB_XianYuZhiYiChapterBase>();
        private List<FB_XianYuZhiYiChapterBase> mListData = new List<FB_XianYuZhiYiChapterBase>();
        public List<FB_XianYuZhiYiChapterBase> ListData
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
        public FB_XianYuZhiYiChapterBase GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_XianYuZhiYiChapterBase);
        }
        public Dictionary<int, FB_XianYuZhiYiChapterBase> GetData()
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
            if (!FB_XianYuZhiYiChapterBaseContainer.FB_XianYuZhiYiChapterBaseContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_XianYuZhiYiChapterBaseContainer.GetRootAsFB_XianYuZhiYiChapterBaseContainer(bb);
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
