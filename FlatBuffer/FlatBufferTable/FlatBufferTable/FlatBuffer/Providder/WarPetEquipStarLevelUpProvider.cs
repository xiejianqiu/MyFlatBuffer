using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_WarPetEquipStarLevelUpProvider
    {
        private static FB_WarPetEquipStarLevelUpProvider _Instance;
        public static FB_WarPetEquipStarLevelUpProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_WarPetEquipStarLevelUpProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/WarPetEquipStarLevelUp.txt";
        protected Dictionary<int, FB_WarPetEquipStarLevelUp> mData = new Dictionary<int, FB_WarPetEquipStarLevelUp>();
        private List<FB_WarPetEquipStarLevelUp> mListData = new List<FB_WarPetEquipStarLevelUp>();
        public List<FB_WarPetEquipStarLevelUp> ListData
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
        public FB_WarPetEquipStarLevelUp GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_WarPetEquipStarLevelUp);
        }
        public Dictionary<int, FB_WarPetEquipStarLevelUp> GetData()
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
            if (!FB_WarPetEquipStarLevelUpContainer.FB_WarPetEquipStarLevelUpContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_WarPetEquipStarLevelUpContainer.GetRootAsFB_WarPetEquipStarLevelUpContainer(bb);
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
