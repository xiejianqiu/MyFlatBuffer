using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_HunJiangSkillBaseProvider
    {
        private static FB_HunJiangSkillBaseProvider _Instance;
        public static FB_HunJiangSkillBaseProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_HunJiangSkillBaseProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/HunJiangSkillBase.txt";
        protected Dictionary<int, FB_HunJiangSkillBase> mData = new Dictionary<int, FB_HunJiangSkillBase>();
        private List<FB_HunJiangSkillBase> mListData = new List<FB_HunJiangSkillBase>();
        public List<FB_HunJiangSkillBase> ListData
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
        public FB_HunJiangSkillBase GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_HunJiangSkillBase);
        }
        public Dictionary<int, FB_HunJiangSkillBase> GetData()
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
            if (!FB_HunJiangSkillBaseContainer.FB_HunJiangSkillBaseContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_HunJiangSkillBaseContainer.GetRootAsFB_HunJiangSkillBaseContainer(bb);
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
