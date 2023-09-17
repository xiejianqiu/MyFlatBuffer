using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_CommonItemProvider
    {
        private static FB_CommonItemProvider _Instance;
        public static FB_CommonItemProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_CommonItemProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/CommonItem.txt";
        protected Dictionary<int, FB_CommonItem> mData = new Dictionary<int, FB_CommonItem>();
        private List<FB_CommonItem> mListData = new List<FB_CommonItem>();
        public List<FB_CommonItem> ListData
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
        public FB_CommonItem GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_CommonItem);
        }
        public Dictionary<int, FB_CommonItem> GetData()
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
            if (!FB_CommonItemContainer.FB_CommonItemContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_CommonItemContainer.GetRootAsFB_CommonItemContainer(bb);
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
