using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_DestinyTemperRateProvider
    {
        private static FB_DestinyTemperRateProvider _Instance;
        public static FB_DestinyTemperRateProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_DestinyTemperRateProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/DestinyTemperRate.txt";
        protected Dictionary<int, FB_DestinyTemperRate> mData = new Dictionary<int, FB_DestinyTemperRate>();
        private List<FB_DestinyTemperRate> mListData = new List<FB_DestinyTemperRate>();
        public List<FB_DestinyTemperRate> ListData
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
        public FB_DestinyTemperRate GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_DestinyTemperRate);
        }
        public Dictionary<int, FB_DestinyTemperRate> GetData()
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
            if (!FB_DestinyTemperRateContainer.FB_DestinyTemperRateContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_DestinyTemperRateContainer.GetRootAsFB_DestinyTemperRateContainer(bb);
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
