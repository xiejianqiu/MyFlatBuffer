using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_EquipExtraAttrProvider
    {
        private static FB_EquipExtraAttrProvider _Instance;
        public static FB_EquipExtraAttrProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_EquipExtraAttrProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/EquipExtraAttr.txt";
        protected Dictionary<int, FB_EquipExtraAttr> mData = new Dictionary<int, FB_EquipExtraAttr>();
        private List<FB_EquipExtraAttr> mListData = new List<FB_EquipExtraAttr>();
        public List<FB_EquipExtraAttr> ListData
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
        public FB_EquipExtraAttr GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_EquipExtraAttr);
        }
        public Dictionary<int, FB_EquipExtraAttr> GetData()
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
            if (!FB_EquipExtraAttrContainer.FB_EquipExtraAttrContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_EquipExtraAttrContainer.GetRootAsFB_EquipExtraAttrContainer(bb);
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
