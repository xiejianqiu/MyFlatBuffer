using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_EquipSlotAttrProvider
    {
        private static FB_EquipSlotAttrProvider _Instance;
        public static FB_EquipSlotAttrProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_EquipSlotAttrProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/EquipSlotAttr.txt";
        protected Dictionary<int, FB_EquipSlotAttr> mData = new Dictionary<int, FB_EquipSlotAttr>();
        private List<FB_EquipSlotAttr> mListData = new List<FB_EquipSlotAttr>();
        public List<FB_EquipSlotAttr> ListData
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
        public FB_EquipSlotAttr GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_EquipSlotAttr);
        }
        public Dictionary<int, FB_EquipSlotAttr> GetData()
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
            if (!FB_EquipSlotAttrContainer.FB_EquipSlotAttrContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_EquipSlotAttrContainer.GetRootAsFB_EquipSlotAttrContainer(bb);
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
