using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_SkillExProvider
    {
        private static FB_SkillExProvider _Instance;
        public static FB_SkillExProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_SkillExProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/SkillEx.txt";
        protected Dictionary<int, FB_SkillEx> mData = new Dictionary<int, FB_SkillEx>();
        private List<FB_SkillEx> mListData = new List<FB_SkillEx>();
        public List<FB_SkillEx> ListData
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
        public FB_SkillEx GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_SkillEx);
        }
        public Dictionary<int, FB_SkillEx> GetData()
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
            if (!FB_SkillExContainer.FB_SkillExContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_SkillExContainer.GetRootAsFB_SkillExContainer(bb);
            for (int index = 0; index < data.ItemsLength; index++)
            {
                var item = data.GetItems(index);
                mData.Add(item.SkillExID, item);
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
