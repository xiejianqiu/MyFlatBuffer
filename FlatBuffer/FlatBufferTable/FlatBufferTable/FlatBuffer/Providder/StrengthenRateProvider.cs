using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_StrengthenRateProvider
    {
        private static FB_StrengthenRateProvider _Instance;
        public static FB_StrengthenRateProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_StrengthenRateProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Client/StrengthenRate.txt";
        protected Dictionary<int, FB_StrengthenRate> mData = new Dictionary<int, FB_StrengthenRate>();
        private List<FB_StrengthenRate> mListData = new List<FB_StrengthenRate>();
        public List<FB_StrengthenRate> ListData
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
        public FB_StrengthenRate GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_StrengthenRate);
        }
        public Dictionary<int, FB_StrengthenRate> GetData()
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
            if (!FB_StrengthenRateContainer.FB_StrengthenRateContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_StrengthenRateContainer.GetRootAsFB_StrengthenRateContainer(bb);
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
