using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_SYHXianYuShengHuiAwardProvider
    {
        private static FB_SYHXianYuShengHuiAwardProvider _Instance;
        public static FB_SYHXianYuShengHuiAwardProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_SYHXianYuShengHuiAwardProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/SYHXianYuShengHuiAward.txt";
        protected Dictionary<int, FB_SYHXianYuShengHuiAward> mData = new Dictionary<int, FB_SYHXianYuShengHuiAward>();
        private List<FB_SYHXianYuShengHuiAward> mListData = new List<FB_SYHXianYuShengHuiAward>();
        public List<FB_SYHXianYuShengHuiAward> ListData
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
        public FB_SYHXianYuShengHuiAward GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_SYHXianYuShengHuiAward);
        }
        public Dictionary<int, FB_SYHXianYuShengHuiAward> GetData()
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
            if (!FB_SYHXianYuShengHuiAwardContainer.FB_SYHXianYuShengHuiAwardContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_SYHXianYuShengHuiAwardContainer.GetRootAsFB_SYHXianYuShengHuiAwardContainer(bb);
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
