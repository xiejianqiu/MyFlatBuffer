using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_ShengLingSkillProvider
    {
        private static FB_ShengLingSkillProvider _Instance;
        public static FB_ShengLingSkillProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_ShengLingSkillProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/ShengLingSkill.txt";
        protected Dictionary<int, FB_ShengLingSkill> mData = new Dictionary<int, FB_ShengLingSkill>();
        private List<FB_ShengLingSkill> mListData = new List<FB_ShengLingSkill>();
        public List<FB_ShengLingSkill> ListData
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
        public FB_ShengLingSkill GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_ShengLingSkill);
        }
        public Dictionary<int, FB_ShengLingSkill> GetData()
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
            if (!FB_ShengLingSkillContainer.FB_ShengLingSkillContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_ShengLingSkillContainer.GetRootAsFB_ShengLingSkillContainer(bb);
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
