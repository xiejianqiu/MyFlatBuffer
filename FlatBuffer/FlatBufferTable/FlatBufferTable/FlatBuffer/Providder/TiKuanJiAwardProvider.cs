using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_TiKuanJiAwardProvider
    {
        private static FB_TiKuanJiAwardProvider _Instance;
        public static FB_TiKuanJiAwardProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_TiKuanJiAwardProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/TiKuanJiAward.txt";
        protected Dictionary<int, FB_TiKuanJiAward> mData = new Dictionary<int, FB_TiKuanJiAward>();
        private List<FB_TiKuanJiAward> mListData = new List<FB_TiKuanJiAward>();
        public List<FB_TiKuanJiAward> ListData
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
        public FB_TiKuanJiAward GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_TiKuanJiAward);
        }
        public Dictionary<int, FB_TiKuanJiAward> GetData()
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
            if (!FB_TiKuanJiAwardContainer.FB_TiKuanJiAwardContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_TiKuanJiAwardContainer.GetRootAsFB_TiKuanJiAwardContainer(bb);
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
