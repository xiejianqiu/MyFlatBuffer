using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_EquipSetStoneGroupAttrProvider
    {
        private static FB_EquipSetStoneGroupAttrProvider _Instance;
        public static FB_EquipSetStoneGroupAttrProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_EquipSetStoneGroupAttrProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/EquipSetStoneGroupAttr.txt";
        protected Dictionary<int, FB_EquipSetStoneGroupAttr> mData = new Dictionary<int, FB_EquipSetStoneGroupAttr>();
        private List<FB_EquipSetStoneGroupAttr> mListData = new List<FB_EquipSetStoneGroupAttr>();
        public List<FB_EquipSetStoneGroupAttr> ListData
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
        public FB_EquipSetStoneGroupAttr GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_EquipSetStoneGroupAttr);
        }
        public Dictionary<int, FB_EquipSetStoneGroupAttr> GetData()
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
            if (!FB_EquipSetStoneGroupAttrContainer.FB_EquipSetStoneGroupAttrContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_EquipSetStoneGroupAttrContainer.GetRootAsFB_EquipSetStoneGroupAttrContainer(bb);
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
