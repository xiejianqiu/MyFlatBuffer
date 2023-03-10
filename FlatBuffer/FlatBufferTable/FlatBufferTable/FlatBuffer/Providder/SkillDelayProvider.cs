using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_SkillDelayProvider
    {
        private static FB_SkillDelayProvider _Instance;
        public static FB_SkillDelayProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_SkillDelayProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/SkillDelay.txt";
        protected Dictionary<int, FB_SkillDelay> mData = new Dictionary<int, FB_SkillDelay>();
        private List<FB_SkillDelay> mListData = new List<FB_SkillDelay>();
        public List<FB_SkillDelay> ListData
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
        public FB_SkillDelay GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_SkillDelay);
        }
        public Dictionary<int, FB_SkillDelay> GetData()
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
            if (!FB_SkillDelayContainer.FB_SkillDelayContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_SkillDelayContainer.GetRootAsFB_SkillDelayContainer(bb);
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
