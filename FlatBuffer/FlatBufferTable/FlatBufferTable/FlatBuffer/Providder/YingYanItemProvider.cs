using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_YingYanItemProvider
    {
        private static FB_YingYanItemProvider _Instance;
        public static FB_YingYanItemProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_YingYanItemProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Client/YingYanItem.txt";
        protected Dictionary<int, FB_YingYanItem> mData = new Dictionary<int, FB_YingYanItem>();
        private List<FB_YingYanItem> mListData = new List<FB_YingYanItem>();
        public List<FB_YingYanItem> ListData
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
        public FB_YingYanItem GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_YingYanItem);
        }
        public Dictionary<int, FB_YingYanItem> GetData()
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
            if (!FB_YingYanItemContainer.FB_YingYanItemContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_YingYanItemContainer.GetRootAsFB_YingYanItemContainer(bb);
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
