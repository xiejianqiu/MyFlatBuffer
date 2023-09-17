using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_DiamondSetProvider
    {
        private static FB_DiamondSetProvider _Instance;
        public static FB_DiamondSetProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_DiamondSetProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/DiamondSet.txt";
        protected Dictionary<int, FB_DiamondSet> mData = new Dictionary<int, FB_DiamondSet>();
        private List<FB_DiamondSet> mListData = new List<FB_DiamondSet>();
        public List<FB_DiamondSet> ListData
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
        public FB_DiamondSet GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_DiamondSet);
        }
        public Dictionary<int, FB_DiamondSet> GetData()
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
            if (!FB_DiamondSetContainer.FB_DiamondSetContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_DiamondSetContainer.GetRootAsFB_DiamondSetContainer(bb);
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
