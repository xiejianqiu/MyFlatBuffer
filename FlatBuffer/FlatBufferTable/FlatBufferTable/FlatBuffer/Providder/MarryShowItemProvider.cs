using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_MarryShowItemProvider
    {
        private static FB_MarryShowItemProvider _Instance;
        public static FB_MarryShowItemProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_MarryShowItemProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/MarryShowItem.txt";
        protected Dictionary<int, FB_MarryShowItem> mData = new Dictionary<int, FB_MarryShowItem>();
        private List<FB_MarryShowItem> mListData = new List<FB_MarryShowItem>();
        public List<FB_MarryShowItem> ListData
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
        public FB_MarryShowItem GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_MarryShowItem);
        }
        public Dictionary<int, FB_MarryShowItem> GetData()
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
            if (!FB_MarryShowItemContainer.FB_MarryShowItemContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_MarryShowItemContainer.GetRootAsFB_MarryShowItemContainer(bb);
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
