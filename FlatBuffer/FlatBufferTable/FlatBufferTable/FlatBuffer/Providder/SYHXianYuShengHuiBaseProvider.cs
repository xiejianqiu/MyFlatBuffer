using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_SYHXianYuShengHuiBaseProvider
    {
        private static FB_SYHXianYuShengHuiBaseProvider _Instance;
        public static FB_SYHXianYuShengHuiBaseProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_SYHXianYuShengHuiBaseProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/SYHXianYuShengHuiBase.txt";
        protected Dictionary<int, FB_SYHXianYuShengHuiBase> mData = new Dictionary<int, FB_SYHXianYuShengHuiBase>();
        private List<FB_SYHXianYuShengHuiBase> mListData = new List<FB_SYHXianYuShengHuiBase>();
        public List<FB_SYHXianYuShengHuiBase> ListData
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
        public FB_SYHXianYuShengHuiBase GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_SYHXianYuShengHuiBase);
        }
        public Dictionary<int, FB_SYHXianYuShengHuiBase> GetData()
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
            if (!FB_SYHXianYuShengHuiBaseContainer.FB_SYHXianYuShengHuiBaseContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_SYHXianYuShengHuiBaseContainer.GetRootAsFB_SYHXianYuShengHuiBaseContainer(bb);
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
