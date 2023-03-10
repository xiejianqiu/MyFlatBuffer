using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_XingHunTeZhiPassiveSkillProvider
    {
        private static FB_XingHunTeZhiPassiveSkillProvider _Instance;
        public static FB_XingHunTeZhiPassiveSkillProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_XingHunTeZhiPassiveSkillProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/XingHunTeZhiPassiveSkill.txt";
        protected Dictionary<int, FB_XingHunTeZhiPassiveSkill> mData = new Dictionary<int, FB_XingHunTeZhiPassiveSkill>();
        private List<FB_XingHunTeZhiPassiveSkill> mListData = new List<FB_XingHunTeZhiPassiveSkill>();
        public List<FB_XingHunTeZhiPassiveSkill> ListData
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
        public FB_XingHunTeZhiPassiveSkill GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_XingHunTeZhiPassiveSkill);
        }
        public Dictionary<int, FB_XingHunTeZhiPassiveSkill> GetData()
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
            if (!FB_XingHunTeZhiPassiveSkillContainer.FB_XingHunTeZhiPassiveSkillContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_XingHunTeZhiPassiveSkillContainer.GetRootAsFB_XingHunTeZhiPassiveSkillContainer(bb);
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
