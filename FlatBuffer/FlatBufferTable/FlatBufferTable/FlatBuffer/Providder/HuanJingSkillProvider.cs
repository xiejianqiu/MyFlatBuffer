using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_HuanJingSkillProvider
    {
        private static FB_HuanJingSkillProvider _Instance;
        public static FB_HuanJingSkillProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_HuanJingSkillProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/HuanJingSkill.txt";
        protected Dictionary<int, FB_HuanJingSkill> mData = new Dictionary<int, FB_HuanJingSkill>();
        private List<FB_HuanJingSkill> mListData = new List<FB_HuanJingSkill>();
        public List<FB_HuanJingSkill> ListData
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
        public FB_HuanJingSkill GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_HuanJingSkill);
        }
        public Dictionary<int, FB_HuanJingSkill> GetData()
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
            if (!FB_HuanJingSkillContainer.FB_HuanJingSkillContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_HuanJingSkillContainer.GetRootAsFB_HuanJingSkillContainer(bb);
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
