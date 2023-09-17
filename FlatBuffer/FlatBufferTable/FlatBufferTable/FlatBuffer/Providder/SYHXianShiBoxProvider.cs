using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_SYHXianShiBoxProvider
    {
        private static FB_SYHXianShiBoxProvider _Instance;
        public static FB_SYHXianShiBoxProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_SYHXianShiBoxProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/SYHXianShiBox.txt";
        protected Dictionary<int, FB_SYHXianShiBox> mData = new Dictionary<int, FB_SYHXianShiBox>();
        private List<FB_SYHXianShiBox> mListData = new List<FB_SYHXianShiBox>();
        public List<FB_SYHXianShiBox> ListData
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
        public FB_SYHXianShiBox GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_SYHXianShiBox);
        }
        public Dictionary<int, FB_SYHXianShiBox> GetData()
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
            if (!FB_SYHXianShiBoxContainer.FB_SYHXianShiBoxContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_SYHXianShiBoxContainer.GetRootAsFB_SYHXianShiBoxContainer(bb);
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
