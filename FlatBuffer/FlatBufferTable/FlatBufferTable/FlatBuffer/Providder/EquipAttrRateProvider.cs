using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_EquipAttrRateProvider
    {
        private static FB_EquipAttrRateProvider _Instance;
        public static FB_EquipAttrRateProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_EquipAttrRateProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/EquipAttrRate.txt";
        protected Dictionary<int, FB_EquipAttrRate> mData = new Dictionary<int, FB_EquipAttrRate>();
        private List<FB_EquipAttrRate> mListData = new List<FB_EquipAttrRate>();
        public List<FB_EquipAttrRate> ListData
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
        public FB_EquipAttrRate GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_EquipAttrRate);
        }
        public Dictionary<int, FB_EquipAttrRate> GetData()
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
            if (!FB_EquipAttrRateContainer.FB_EquipAttrRateContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_EquipAttrRateContainer.GetRootAsFB_EquipAttrRateContainer(bb);
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
