using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_PeiShiCompoundTypeProvider
    {
        private static FB_PeiShiCompoundTypeProvider _Instance;
        public static FB_PeiShiCompoundTypeProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_PeiShiCompoundTypeProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/PeiShiCompoundType.txt";
        protected Dictionary<int, FB_PeiShiCompoundType> mData = new Dictionary<int, FB_PeiShiCompoundType>();
        private List<FB_PeiShiCompoundType> mListData = new List<FB_PeiShiCompoundType>();
        public List<FB_PeiShiCompoundType> ListData
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
        public FB_PeiShiCompoundType GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_PeiShiCompoundType);
        }
        public Dictionary<int, FB_PeiShiCompoundType> GetData()
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
            if (!FB_PeiShiCompoundTypeContainer.FB_PeiShiCompoundTypeContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_PeiShiCompoundTypeContainer.GetRootAsFB_PeiShiCompoundTypeContainer(bb);
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
