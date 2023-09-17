using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_LingGangSkillBaseProvider
    {
        private static FB_LingGangSkillBaseProvider _Instance;
        public static FB_LingGangSkillBaseProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_LingGangSkillBaseProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/LingGangSkillBase.txt";
        protected Dictionary<int, FB_LingGangSkillBase> mData = new Dictionary<int, FB_LingGangSkillBase>();
        private List<FB_LingGangSkillBase> mListData = new List<FB_LingGangSkillBase>();
        public List<FB_LingGangSkillBase> ListData
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
        public FB_LingGangSkillBase GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_LingGangSkillBase);
        }
        public Dictionary<int, FB_LingGangSkillBase> GetData()
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
            if (!FB_LingGangSkillBaseContainer.FB_LingGangSkillBaseContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_LingGangSkillBaseContainer.GetRootAsFB_LingGangSkillBaseContainer(bb);
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
