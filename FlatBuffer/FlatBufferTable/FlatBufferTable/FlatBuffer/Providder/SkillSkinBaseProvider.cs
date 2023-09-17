using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_SkillSkinBaseProvider
    {
        private static FB_SkillSkinBaseProvider _Instance;
        public static FB_SkillSkinBaseProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_SkillSkinBaseProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/SkillSkinBase.txt";
        protected Dictionary<int, FB_SkillSkinBase> mData = new Dictionary<int, FB_SkillSkinBase>();
        private List<FB_SkillSkinBase> mListData = new List<FB_SkillSkinBase>();
        public List<FB_SkillSkinBase> ListData
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
        public FB_SkillSkinBase GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_SkillSkinBase);
        }
        public Dictionary<int, FB_SkillSkinBase> GetData()
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
            if (!FB_SkillSkinBaseContainer.FB_SkillSkinBaseContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_SkillSkinBaseContainer.GetRootAsFB_SkillSkinBaseContainer(bb);
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
