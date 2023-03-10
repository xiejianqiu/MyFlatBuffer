using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_LingGangSkillLevelUpProvider
    {
        private static FB_LingGangSkillLevelUpProvider _Instance;
        public static FB_LingGangSkillLevelUpProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_LingGangSkillLevelUpProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/LingGangSkillLevelUp.txt";
        protected Dictionary<int, FB_LingGangSkillLevelUp> mData = new Dictionary<int, FB_LingGangSkillLevelUp>();
        private List<FB_LingGangSkillLevelUp> mListData = new List<FB_LingGangSkillLevelUp>();
        public List<FB_LingGangSkillLevelUp> ListData
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
        public FB_LingGangSkillLevelUp GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_LingGangSkillLevelUp);
        }
        public Dictionary<int, FB_LingGangSkillLevelUp> GetData()
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
            if (!FB_LingGangSkillLevelUpContainer.FB_LingGangSkillLevelUpContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_LingGangSkillLevelUpContainer.GetRootAsFB_LingGangSkillLevelUpContainer(bb);
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
