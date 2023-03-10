using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_JuhunBoxWeightProvider
    {
        private static FB_JuhunBoxWeightProvider _Instance;
        public static FB_JuhunBoxWeightProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_JuhunBoxWeightProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/JuhunBoxWeight.txt";
        protected Dictionary<int, FB_JuhunBoxWeight> mData = new Dictionary<int, FB_JuhunBoxWeight>();
        private List<FB_JuhunBoxWeight> mListData = new List<FB_JuhunBoxWeight>();
        public List<FB_JuhunBoxWeight> ListData
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
        public FB_JuhunBoxWeight GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_JuhunBoxWeight);
        }
        public Dictionary<int, FB_JuhunBoxWeight> GetData()
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
            if (!FB_JuhunBoxWeightContainer.FB_JuhunBoxWeightContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_JuhunBoxWeightContainer.GetRootAsFB_JuhunBoxWeightContainer(bb);
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
