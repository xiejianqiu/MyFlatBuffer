using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_StarAttributeProvider
    {
        private static FB_StarAttributeProvider _Instance;
        public static FB_StarAttributeProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_StarAttributeProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/StarAttribute.txt";
        protected Dictionary<int, FB_StarAttribute> mData = new Dictionary<int, FB_StarAttribute>();
        private List<FB_StarAttribute> mListData = new List<FB_StarAttribute>();
        public List<FB_StarAttribute> ListData
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
        public FB_StarAttribute GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_StarAttribute);
        }
        public Dictionary<int, FB_StarAttribute> GetData()
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
            if (!FB_StarAttributeContainer.FB_StarAttributeContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_StarAttributeContainer.GetRootAsFB_StarAttributeContainer(bb);
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
