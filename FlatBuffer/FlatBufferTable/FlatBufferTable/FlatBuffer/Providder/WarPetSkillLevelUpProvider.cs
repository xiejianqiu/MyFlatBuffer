using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_WarPetSkillLevelUpProvider
    {
        private static FB_WarPetSkillLevelUpProvider _Instance;
        public static FB_WarPetSkillLevelUpProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_WarPetSkillLevelUpProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/WarPetSkillLevelUp.txt";
        protected Dictionary<int, FB_WarPetSkillLevelUp> mData = new Dictionary<int, FB_WarPetSkillLevelUp>();
        private List<FB_WarPetSkillLevelUp> mListData = new List<FB_WarPetSkillLevelUp>();
        public List<FB_WarPetSkillLevelUp> ListData
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
        public FB_WarPetSkillLevelUp GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_WarPetSkillLevelUp);
        }
        public Dictionary<int, FB_WarPetSkillLevelUp> GetData()
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
            if (!FB_WarPetSkillLevelUpContainer.FB_WarPetSkillLevelUpContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_WarPetSkillLevelUpContainer.GetRootAsFB_WarPetSkillLevelUpContainer(bb);
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
