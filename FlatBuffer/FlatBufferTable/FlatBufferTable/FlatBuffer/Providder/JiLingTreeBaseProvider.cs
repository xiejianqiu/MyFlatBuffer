using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_JiLingTreeBaseProvider
    {
        private static FB_JiLingTreeBaseProvider _Instance;
        public static FB_JiLingTreeBaseProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_JiLingTreeBaseProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Client/JiLingTreeBase.txt";
        protected Dictionary<int, FB_JiLingTreeBase> mData = new Dictionary<int, FB_JiLingTreeBase>();
        private List<FB_JiLingTreeBase> mListData = new List<FB_JiLingTreeBase>();
        public List<FB_JiLingTreeBase> ListData
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
        public FB_JiLingTreeBase GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_JiLingTreeBase);
        }
        public Dictionary<int, FB_JiLingTreeBase> GetData()
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
            if (!FB_JiLingTreeBaseContainer.FB_JiLingTreeBaseContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_JiLingTreeBaseContainer.GetRootAsFB_JiLingTreeBaseContainer(bb);
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
