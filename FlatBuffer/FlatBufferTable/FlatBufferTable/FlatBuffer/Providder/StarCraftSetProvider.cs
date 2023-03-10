using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_StarCraftSetProvider
    {
        private static FB_StarCraftSetProvider _Instance;
        public static FB_StarCraftSetProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_StarCraftSetProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/StarCraftSet.txt";
        protected Dictionary<int, FB_StarCraftSet> mData = new Dictionary<int, FB_StarCraftSet>();
        private List<FB_StarCraftSet> mListData = new List<FB_StarCraftSet>();
        public List<FB_StarCraftSet> ListData
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
        public FB_StarCraftSet GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_StarCraftSet);
        }
        public Dictionary<int, FB_StarCraftSet> GetData()
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
            if (!FB_StarCraftSetContainer.FB_StarCraftSetContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_StarCraftSetContainer.GetRootAsFB_StarCraftSetContainer(bb);
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
