using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_HuanJingTypeProvider
    {
        private static FB_HuanJingTypeProvider _Instance;
        public static FB_HuanJingTypeProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_HuanJingTypeProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/HuanJingType.txt";
        protected Dictionary<int, FB_HuanJingType> mData = new Dictionary<int, FB_HuanJingType>();
        private List<FB_HuanJingType> mListData = new List<FB_HuanJingType>();
        public List<FB_HuanJingType> ListData
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
        public FB_HuanJingType GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_HuanJingType);
        }
        public Dictionary<int, FB_HuanJingType> GetData()
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
            if (!FB_HuanJingTypeContainer.FB_HuanJingTypeContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_HuanJingTypeContainer.GetRootAsFB_HuanJingTypeContainer(bb);
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
