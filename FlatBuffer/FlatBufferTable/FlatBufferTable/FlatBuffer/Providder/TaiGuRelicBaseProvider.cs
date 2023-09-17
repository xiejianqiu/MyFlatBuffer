using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_TaiGuRelicBaseProvider
    {
        private static FB_TaiGuRelicBaseProvider _Instance;
        public static FB_TaiGuRelicBaseProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_TaiGuRelicBaseProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/TaiGuRelicBase.txt";
        protected Dictionary<int, FB_TaiGuRelicBase> mData = new Dictionary<int, FB_TaiGuRelicBase>();
        private List<FB_TaiGuRelicBase> mListData = new List<FB_TaiGuRelicBase>();
        public List<FB_TaiGuRelicBase> ListData
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
        public FB_TaiGuRelicBase GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_TaiGuRelicBase);
        }
        public Dictionary<int, FB_TaiGuRelicBase> GetData()
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
            if (!FB_TaiGuRelicBaseContainer.FB_TaiGuRelicBaseContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_TaiGuRelicBaseContainer.GetRootAsFB_TaiGuRelicBaseContainer(bb);
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
