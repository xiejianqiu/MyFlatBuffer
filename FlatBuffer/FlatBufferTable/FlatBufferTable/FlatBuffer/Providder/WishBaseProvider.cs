using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_WishBaseProvider
    {
        private static FB_WishBaseProvider _Instance;
        public static FB_WishBaseProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_WishBaseProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/WishBase.txt";
        protected Dictionary<int, FB_WishBase> mData = new Dictionary<int, FB_WishBase>();
        private List<FB_WishBase> mListData = new List<FB_WishBase>();
        public List<FB_WishBase> ListData
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
        public FB_WishBase GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_WishBase);
        }
        public Dictionary<int, FB_WishBase> GetData()
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
            if (!FB_WishBaseContainer.FB_WishBaseContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_WishBaseContainer.GetRootAsFB_WishBaseContainer(bb);
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
