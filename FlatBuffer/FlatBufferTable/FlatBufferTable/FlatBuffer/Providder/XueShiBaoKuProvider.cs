using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_XueShiBaoKuProvider
    {
        private static FB_XueShiBaoKuProvider _Instance;
        public static FB_XueShiBaoKuProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_XueShiBaoKuProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/XueShiBaoKu.txt";
        protected Dictionary<int, FB_XueShiBaoKu> mData = new Dictionary<int, FB_XueShiBaoKu>();
        private List<FB_XueShiBaoKu> mListData = new List<FB_XueShiBaoKu>();
        public List<FB_XueShiBaoKu> ListData
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
        public FB_XueShiBaoKu GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_XueShiBaoKu);
        }
        public Dictionary<int, FB_XueShiBaoKu> GetData()
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
            if (!FB_XueShiBaoKuContainer.FB_XueShiBaoKuContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_XueShiBaoKuContainer.GetRootAsFB_XueShiBaoKuContainer(bb);
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
