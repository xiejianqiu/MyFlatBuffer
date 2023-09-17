using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_ImpactProvider
    {
        private static FB_ImpactProvider _Instance;
        public static FB_ImpactProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_ImpactProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/Impact.txt";
        protected Dictionary<int, FB_Impact> mData = new Dictionary<int, FB_Impact>();
        private List<FB_Impact> mListData = new List<FB_Impact>();
        public List<FB_Impact> ListData
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
        public FB_Impact GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_Impact);
        }
        public Dictionary<int, FB_Impact> GetData()
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
            if (!FB_ImpactContainer.FB_ImpactContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_ImpactContainer.GetRootAsFB_ImpactContainer(bb);
            for (int index = 0; index < data.ItemsLength; index++)
            {
                var item = data.GetItems(index);
                mData.Add(item.ImpactID, item);
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
