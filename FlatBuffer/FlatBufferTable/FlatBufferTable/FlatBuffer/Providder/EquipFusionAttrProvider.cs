using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_EquipFusionAttrProvider
    {
        private static FB_EquipFusionAttrProvider _Instance;
        public static FB_EquipFusionAttrProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_EquipFusionAttrProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/EquipFusionAttr.txt";
        protected Dictionary<int, FB_EquipFusionAttr> mData = new Dictionary<int, FB_EquipFusionAttr>();
        private List<FB_EquipFusionAttr> mListData = new List<FB_EquipFusionAttr>();
        public List<FB_EquipFusionAttr> ListData
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
        public FB_EquipFusionAttr GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_EquipFusionAttr);
        }
        public Dictionary<int, FB_EquipFusionAttr> GetData()
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
            if (!FB_EquipFusionAttrContainer.FB_EquipFusionAttrContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_EquipFusionAttrContainer.GetRootAsFB_EquipFusionAttrContainer(bb);
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
