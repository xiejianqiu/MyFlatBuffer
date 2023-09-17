using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_ShenShouSkillProvider
    {
        private static FB_ShenShouSkillProvider _Instance;
        public static FB_ShenShouSkillProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_ShenShouSkillProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/ShenShouSkill.txt";
        protected Dictionary<int, FB_ShenShouSkill> mData = new Dictionary<int, FB_ShenShouSkill>();
        private List<FB_ShenShouSkill> mListData = new List<FB_ShenShouSkill>();
        public List<FB_ShenShouSkill> ListData
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
        public FB_ShenShouSkill GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_ShenShouSkill);
        }
        public Dictionary<int, FB_ShenShouSkill> GetData()
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
            if (!FB_ShenShouSkillContainer.FB_ShenShouSkillContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_ShenShouSkillContainer.GetRootAsFB_ShenShouSkillContainer(bb);
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
