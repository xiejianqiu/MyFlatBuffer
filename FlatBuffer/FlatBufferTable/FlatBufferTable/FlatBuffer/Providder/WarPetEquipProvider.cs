using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_WarPetEquipProvider
    {
        private static FB_WarPetEquipProvider _Instance;
        public static FB_WarPetEquipProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_WarPetEquipProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/WarPetEquip.txt";
        protected Dictionary<int, FB_WarPetEquip> mData = new Dictionary<int, FB_WarPetEquip>();
        private List<FB_WarPetEquip> mListData = new List<FB_WarPetEquip>();
        public List<FB_WarPetEquip> ListData
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
        public FB_WarPetEquip GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_WarPetEquip);
        }
        public Dictionary<int, FB_WarPetEquip> GetData()
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
            if (!FB_WarPetEquipContainer.FB_WarPetEquipContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_WarPetEquipContainer.GetRootAsFB_WarPetEquipContainer(bb);
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
