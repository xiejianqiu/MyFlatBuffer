using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_ItemCompoundTypeProvider
    {
        private static FB_ItemCompoundTypeProvider _Instance;
        public static FB_ItemCompoundTypeProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_ItemCompoundTypeProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/ItemCompoundType.txt";
        protected Dictionary<int, FB_ItemCompoundType> mData = new Dictionary<int, FB_ItemCompoundType>();
        private List<FB_ItemCompoundType> mListData = new List<FB_ItemCompoundType>();
        public List<FB_ItemCompoundType> ListData
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
        public FB_ItemCompoundType GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_ItemCompoundType);
        }
        public Dictionary<int, FB_ItemCompoundType> GetData()
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
            if (!FB_ItemCompoundTypeContainer.FB_ItemCompoundTypeContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_ItemCompoundTypeContainer.GetRootAsFB_ItemCompoundTypeContainer(bb);
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
