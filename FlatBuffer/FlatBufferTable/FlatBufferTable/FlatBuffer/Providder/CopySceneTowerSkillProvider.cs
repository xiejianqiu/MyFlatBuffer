using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_CopySceneTowerSkillProvider
    {
        private static FB_CopySceneTowerSkillProvider _Instance;
        public static FB_CopySceneTowerSkillProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_CopySceneTowerSkillProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/CopySceneTowerSkill.txt";
        protected Dictionary<int, FB_CopySceneTowerSkill> mData = new Dictionary<int, FB_CopySceneTowerSkill>();
        private List<FB_CopySceneTowerSkill> mListData = new List<FB_CopySceneTowerSkill>();
        public List<FB_CopySceneTowerSkill> ListData
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
        public FB_CopySceneTowerSkill GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_CopySceneTowerSkill);
        }
        public Dictionary<int, FB_CopySceneTowerSkill> GetData()
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
            if (!FB_CopySceneTowerSkillContainer.FB_CopySceneTowerSkillContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_CopySceneTowerSkillContainer.GetRootAsFB_CopySceneTowerSkillContainer(bb);
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
