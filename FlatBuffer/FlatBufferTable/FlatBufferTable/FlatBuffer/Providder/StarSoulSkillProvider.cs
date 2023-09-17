using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_StarSoulSkillProvider
    {
        private static FB_StarSoulSkillProvider _Instance;
        public static FB_StarSoulSkillProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_StarSoulSkillProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/StarSoulSkill.txt";
        protected Dictionary<int, FB_StarSoulSkill> mData = new Dictionary<int, FB_StarSoulSkill>();
        private List<FB_StarSoulSkill> mListData = new List<FB_StarSoulSkill>();
        public List<FB_StarSoulSkill> ListData
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
        public FB_StarSoulSkill GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_StarSoulSkill);
        }
        public Dictionary<int, FB_StarSoulSkill> GetData()
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
            if (!FB_StarSoulSkillContainer.FB_StarSoulSkillContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_StarSoulSkillContainer.GetRootAsFB_StarSoulSkillContainer(bb);
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
