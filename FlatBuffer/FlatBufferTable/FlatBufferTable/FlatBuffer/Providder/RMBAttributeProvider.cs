using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_RMBAttributeProvider
    {
        private static FB_RMBAttributeProvider _Instance;
        public static FB_RMBAttributeProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_RMBAttributeProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/RMBAttribute.txt";
        protected Dictionary<int, FB_RMBAttribute> mData = new Dictionary<int, FB_RMBAttribute>();
        private List<FB_RMBAttribute> mListData = new List<FB_RMBAttribute>();
        public List<FB_RMBAttribute> ListData
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
        public FB_RMBAttribute GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_RMBAttribute);
        }
        public Dictionary<int, FB_RMBAttribute> GetData()
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
            if (!FB_RMBAttributeContainer.FB_RMBAttributeContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_RMBAttributeContainer.GetRootAsFB_RMBAttributeContainer(bb);
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
