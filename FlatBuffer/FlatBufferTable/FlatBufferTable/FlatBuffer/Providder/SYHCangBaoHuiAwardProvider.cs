using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_SYHCangBaoHuiAwardProvider
    {
        private static FB_SYHCangBaoHuiAwardProvider _Instance;
        public static FB_SYHCangBaoHuiAwardProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_SYHCangBaoHuiAwardProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/SYHCangBaoHuiAward.txt";
        protected Dictionary<int, FB_SYHCangBaoHuiAward> mData = new Dictionary<int, FB_SYHCangBaoHuiAward>();
        private List<FB_SYHCangBaoHuiAward> mListData = new List<FB_SYHCangBaoHuiAward>();
        public List<FB_SYHCangBaoHuiAward> ListData
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
        public FB_SYHCangBaoHuiAward GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_SYHCangBaoHuiAward);
        }
        public Dictionary<int, FB_SYHCangBaoHuiAward> GetData()
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
            if (!FB_SYHCangBaoHuiAwardContainer.FB_SYHCangBaoHuiAwardContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_SYHCangBaoHuiAwardContainer.GetRootAsFB_SYHCangBaoHuiAwardContainer(bb);
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
