using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_HuanJingEquipSlotProvider
    {
        private static FB_HuanJingEquipSlotProvider _Instance;
        public static FB_HuanJingEquipSlotProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_HuanJingEquipSlotProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/HuanJingEquipSlot.txt";
        protected Dictionary<int, FB_HuanJingEquipSlot> mData = new Dictionary<int, FB_HuanJingEquipSlot>();
        private List<FB_HuanJingEquipSlot> mListData = new List<FB_HuanJingEquipSlot>();
        public List<FB_HuanJingEquipSlot> ListData
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
        public FB_HuanJingEquipSlot GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_HuanJingEquipSlot);
        }
        public Dictionary<int, FB_HuanJingEquipSlot> GetData()
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
            if (!FB_HuanJingEquipSlotContainer.FB_HuanJingEquipSlotContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_HuanJingEquipSlotContainer.GetRootAsFB_HuanJingEquipSlotContainer(bb);
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
