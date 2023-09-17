using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_EquipExchangeProvider
    {
        private static FB_EquipExchangeProvider _Instance;
        public static FB_EquipExchangeProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_EquipExchangeProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/EquipExchange.txt";
        protected Dictionary<int, FB_EquipExchange> mData = new Dictionary<int, FB_EquipExchange>();
        private List<FB_EquipExchange> mListData = new List<FB_EquipExchange>();
        public List<FB_EquipExchange> ListData
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
        public FB_EquipExchange GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_EquipExchange);
        }
        public Dictionary<int, FB_EquipExchange> GetData()
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
            if (!FB_EquipExchangeContainer.FB_EquipExchangeContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_EquipExchangeContainer.GetRootAsFB_EquipExchangeContainer(bb);
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
