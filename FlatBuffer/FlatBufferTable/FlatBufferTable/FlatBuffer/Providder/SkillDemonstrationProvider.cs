using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_SkillDemonstrationProvider
    {
        private static FB_SkillDemonstrationProvider _Instance;
        public static FB_SkillDemonstrationProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_SkillDemonstrationProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Client/SkillDemonstration.txt";
        protected Dictionary<int, FB_SkillDemonstration> mData = new Dictionary<int, FB_SkillDemonstration>();
        private List<FB_SkillDemonstration> mListData = new List<FB_SkillDemonstration>();
        public List<FB_SkillDemonstration> ListData
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
        public FB_SkillDemonstration GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_SkillDemonstration);
        }
        public Dictionary<int, FB_SkillDemonstration> GetData()
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
            if (!FB_SkillDemonstrationContainer.FB_SkillDemonstrationContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_SkillDemonstrationContainer.GetRootAsFB_SkillDemonstrationContainer(bb);
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
