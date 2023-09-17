using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_RuneBoxWeightProvider
    {
        private static FB_RuneBoxWeightProvider _Instance;
        public static FB_RuneBoxWeightProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_RuneBoxWeightProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/RuneBoxWeight.txt";
        protected Dictionary<int, FB_RuneBoxWeight> mData = new Dictionary<int, FB_RuneBoxWeight>();
        private List<FB_RuneBoxWeight> mListData = new List<FB_RuneBoxWeight>();
        public List<FB_RuneBoxWeight> ListData
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
        public FB_RuneBoxWeight GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_RuneBoxWeight);
        }
        public Dictionary<int, FB_RuneBoxWeight> GetData()
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
            if (!FB_RuneBoxWeightContainer.FB_RuneBoxWeightContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_RuneBoxWeightContainer.GetRootAsFB_RuneBoxWeightContainer(bb);
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
