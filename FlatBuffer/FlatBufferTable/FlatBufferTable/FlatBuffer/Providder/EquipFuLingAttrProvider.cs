using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_EquipFuLingAttrProvider
    {
        private static FB_EquipFuLingAttrProvider _Instance;
        public static FB_EquipFuLingAttrProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_EquipFuLingAttrProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/EquipFuLingAttr.txt";
        protected Dictionary<int, FB_EquipFuLingAttr> mData = new Dictionary<int, FB_EquipFuLingAttr>();
        private List<FB_EquipFuLingAttr> mListData = new List<FB_EquipFuLingAttr>();
        public List<FB_EquipFuLingAttr> ListData
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
        public FB_EquipFuLingAttr GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_EquipFuLingAttr);
        }
        public Dictionary<int, FB_EquipFuLingAttr> GetData()
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
            if (!FB_EquipFuLingAttrContainer.FB_EquipFuLingAttrContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_EquipFuLingAttrContainer.GetRootAsFB_EquipFuLingAttrContainer(bb);
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
