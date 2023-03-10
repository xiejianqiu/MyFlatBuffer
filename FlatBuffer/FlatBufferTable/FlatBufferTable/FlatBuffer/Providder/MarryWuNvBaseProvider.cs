using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_MarryWuNvBaseProvider
    {
        private static FB_MarryWuNvBaseProvider _Instance;
        public static FB_MarryWuNvBaseProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_MarryWuNvBaseProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/MarryWuNvBase.txt";
        protected Dictionary<int, FB_MarryWuNvBase> mData = new Dictionary<int, FB_MarryWuNvBase>();
        private List<FB_MarryWuNvBase> mListData = new List<FB_MarryWuNvBase>();
        public List<FB_MarryWuNvBase> ListData
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
        public FB_MarryWuNvBase GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_MarryWuNvBase);
        }
        public Dictionary<int, FB_MarryWuNvBase> GetData()
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
            if (!FB_MarryWuNvBaseContainer.FB_MarryWuNvBaseContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_MarryWuNvBaseContainer.GetRootAsFB_MarryWuNvBaseContainer(bb);
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
