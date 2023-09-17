using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_WuXingYuanLiProvider
    {
        private static FB_WuXingYuanLiProvider _Instance;
        public static FB_WuXingYuanLiProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_WuXingYuanLiProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/WuXingYuanLi.txt";
        protected Dictionary<int, FB_WuXingYuanLi> mData = new Dictionary<int, FB_WuXingYuanLi>();
        private List<FB_WuXingYuanLi> mListData = new List<FB_WuXingYuanLi>();
        public List<FB_WuXingYuanLi> ListData
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
        public FB_WuXingYuanLi GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_WuXingYuanLi);
        }
        public Dictionary<int, FB_WuXingYuanLi> GetData()
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
            if (!FB_WuXingYuanLiContainer.FB_WuXingYuanLiContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_WuXingYuanLiContainer.GetRootAsFB_WuXingYuanLiContainer(bb);
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
