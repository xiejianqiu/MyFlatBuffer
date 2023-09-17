using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_SYHXianShiQiangGouProvider
    {
        private static FB_SYHXianShiQiangGouProvider _Instance;
        public static FB_SYHXianShiQiangGouProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_SYHXianShiQiangGouProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/SYHXianShiQiangGou.txt";
        protected Dictionary<int, FB_SYHXianShiQiangGou> mData = new Dictionary<int, FB_SYHXianShiQiangGou>();
        private List<FB_SYHXianShiQiangGou> mListData = new List<FB_SYHXianShiQiangGou>();
        public List<FB_SYHXianShiQiangGou> ListData
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
        public FB_SYHXianShiQiangGou GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_SYHXianShiQiangGou);
        }
        public Dictionary<int, FB_SYHXianShiQiangGou> GetData()
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
            if (!FB_SYHXianShiQiangGouContainer.FB_SYHXianShiQiangGouContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_SYHXianShiQiangGouContainer.GetRootAsFB_SYHXianShiQiangGouContainer(bb);
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
