using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_EquipStrengthenProvider
    {
        private static FB_EquipStrengthenProvider _Instance;
        public static FB_EquipStrengthenProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_EquipStrengthenProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/EquipStrengthen.txt";
        protected Dictionary<int, FB_EquipStrengthen> mData = new Dictionary<int, FB_EquipStrengthen>();
        private List<FB_EquipStrengthen> mListData = new List<FB_EquipStrengthen>();
        public List<FB_EquipStrengthen> ListData
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
        public FB_EquipStrengthen GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_EquipStrengthen);
        }
        public Dictionary<int, FB_EquipStrengthen> GetData()
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
            if (!FB_EquipStrengthenContainer.FB_EquipStrengthenContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_EquipStrengthenContainer.GetRootAsFB_EquipStrengthenContainer(bb);
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
