using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_HunJiangJiBanSkillProvider
    {
        private static FB_HunJiangJiBanSkillProvider _Instance;
        public static FB_HunJiangJiBanSkillProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_HunJiangJiBanSkillProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/HunJiangJiBanSkill.txt";
        protected Dictionary<int, FB_HunJiangJiBanSkill> mData = new Dictionary<int, FB_HunJiangJiBanSkill>();
        private List<FB_HunJiangJiBanSkill> mListData = new List<FB_HunJiangJiBanSkill>();
        public List<FB_HunJiangJiBanSkill> ListData
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
        public FB_HunJiangJiBanSkill GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_HunJiangJiBanSkill);
        }
        public Dictionary<int, FB_HunJiangJiBanSkill> GetData()
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
            if (!FB_HunJiangJiBanSkillContainer.FB_HunJiangJiBanSkillContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_HunJiangJiBanSkillContainer.GetRootAsFB_HunJiangJiBanSkillContainer(bb);
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
