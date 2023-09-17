using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_WarPetSkillProvider
    {
        private static FB_WarPetSkillProvider _Instance;
        public static FB_WarPetSkillProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_WarPetSkillProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/WarPetSkill.txt";
        protected Dictionary<int, FB_WarPetSkill> mData = new Dictionary<int, FB_WarPetSkill>();
        private List<FB_WarPetSkill> mListData = new List<FB_WarPetSkill>();
        public List<FB_WarPetSkill> ListData
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
        public FB_WarPetSkill GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_WarPetSkill);
        }
        public Dictionary<int, FB_WarPetSkill> GetData()
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
            if (!FB_WarPetSkillContainer.FB_WarPetSkillContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_WarPetSkillContainer.GetRootAsFB_WarPetSkillContainer(bb);
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
