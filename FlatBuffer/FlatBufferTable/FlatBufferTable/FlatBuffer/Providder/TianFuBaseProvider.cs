using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_TianFuBaseProvider
    {
        private static FB_TianFuBaseProvider _Instance;
        public static FB_TianFuBaseProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_TianFuBaseProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/TianFuBase.txt";
        protected Dictionary<int, FB_TianFuBase> mData = new Dictionary<int, FB_TianFuBase>();
        private List<FB_TianFuBase> mListData = new List<FB_TianFuBase>();
        public List<FB_TianFuBase> ListData
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
        public FB_TianFuBase GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_TianFuBase);
        }
        public Dictionary<int, FB_TianFuBase> GetData()
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
            if (!FB_TianFuBaseContainer.FB_TianFuBaseContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_TianFuBaseContainer.GetRootAsFB_TianFuBaseContainer(bb);
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
