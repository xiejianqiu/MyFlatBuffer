using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_WarPetEquipLevelUpProvider
    {
        private static FB_WarPetEquipLevelUpProvider _Instance;
        public static FB_WarPetEquipLevelUpProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_WarPetEquipLevelUpProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/WarPetEquipLevelUp.txt";
        protected Dictionary<int, FB_WarPetEquipLevelUp> mData = new Dictionary<int, FB_WarPetEquipLevelUp>();
        private List<FB_WarPetEquipLevelUp> mListData = new List<FB_WarPetEquipLevelUp>();
        public List<FB_WarPetEquipLevelUp> ListData
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
        public FB_WarPetEquipLevelUp GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_WarPetEquipLevelUp);
        }
        public Dictionary<int, FB_WarPetEquipLevelUp> GetData()
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
            if (!FB_WarPetEquipLevelUpContainer.FB_WarPetEquipLevelUpContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_WarPetEquipLevelUpContainer.GetRootAsFB_WarPetEquipLevelUpContainer(bb);
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
