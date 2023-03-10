using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_DiamondAttributeProvider
    {
        private static FB_DiamondAttributeProvider _Instance;
        public static FB_DiamondAttributeProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_DiamondAttributeProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/DiamondAttribute.txt";
        protected Dictionary<int, FB_DiamondAttribute> mData = new Dictionary<int, FB_DiamondAttribute>();
        private List<FB_DiamondAttribute> mListData = new List<FB_DiamondAttribute>();
        public List<FB_DiamondAttribute> ListData
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
        public FB_DiamondAttribute GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_DiamondAttribute);
        }
        public Dictionary<int, FB_DiamondAttribute> GetData()
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
            if (!FB_DiamondAttributeContainer.FB_DiamondAttributeContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_DiamondAttributeContainer.GetRootAsFB_DiamondAttributeContainer(bb);
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
