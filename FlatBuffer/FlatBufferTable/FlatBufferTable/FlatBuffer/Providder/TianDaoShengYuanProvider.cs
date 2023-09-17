using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_TianDaoShengYuanProvider
    {
        private static FB_TianDaoShengYuanProvider _Instance;
        public static FB_TianDaoShengYuanProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_TianDaoShengYuanProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/TianDaoShengYuan.txt";
        protected Dictionary<int, FB_TianDaoShengYuan> mData = new Dictionary<int, FB_TianDaoShengYuan>();
        private List<FB_TianDaoShengYuan> mListData = new List<FB_TianDaoShengYuan>();
        public List<FB_TianDaoShengYuan> ListData
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
        public FB_TianDaoShengYuan GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_TianDaoShengYuan);
        }
        public Dictionary<int, FB_TianDaoShengYuan> GetData()
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
            if (!FB_TianDaoShengYuanContainer.FB_TianDaoShengYuanContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_TianDaoShengYuanContainer.GetRootAsFB_TianDaoShengYuanContainer(bb);
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
