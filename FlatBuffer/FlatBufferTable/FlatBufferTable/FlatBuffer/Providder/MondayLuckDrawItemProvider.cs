using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_MondayLuckDrawItemProvider
    {
        private static FB_MondayLuckDrawItemProvider _Instance;
        public static FB_MondayLuckDrawItemProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_MondayLuckDrawItemProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/MondayLuckDrawItem.txt";
        protected Dictionary<int, FB_MondayLuckDrawItem> mData = new Dictionary<int, FB_MondayLuckDrawItem>();
        private List<FB_MondayLuckDrawItem> mListData = new List<FB_MondayLuckDrawItem>();
        public List<FB_MondayLuckDrawItem> ListData
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
        public FB_MondayLuckDrawItem GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_MondayLuckDrawItem);
        }
        public Dictionary<int, FB_MondayLuckDrawItem> GetData()
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
            if (!FB_MondayLuckDrawItemContainer.FB_MondayLuckDrawItemContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_MondayLuckDrawItemContainer.GetRootAsFB_MondayLuckDrawItemContainer(bb);
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
