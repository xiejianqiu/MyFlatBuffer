using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_SkillListProvider
    {
        private static FB_SkillListProvider _Instance;
        public static FB_SkillListProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_SkillListProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/SkillList.txt";
        protected Dictionary<int, FB_SkillList> mData = new Dictionary<int, FB_SkillList>();
        private List<FB_SkillList> mListData = new List<FB_SkillList>();
        public List<FB_SkillList> ListData
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
        public FB_SkillList GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_SkillList);
        }
        public Dictionary<int, FB_SkillList> GetData()
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
            if (!FB_SkillListContainer.FB_SkillListContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_SkillListContainer.GetRootAsFB_SkillListContainer(bb);
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
