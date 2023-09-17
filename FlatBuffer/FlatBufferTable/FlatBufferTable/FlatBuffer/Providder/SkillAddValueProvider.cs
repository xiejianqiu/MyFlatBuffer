using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_SkillAddValueProvider
    {
        private static FB_SkillAddValueProvider _Instance;
        public static FB_SkillAddValueProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_SkillAddValueProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/SkillAddValue.txt";
        protected Dictionary<int, FB_SkillAddValue> mData = new Dictionary<int, FB_SkillAddValue>();
        private List<FB_SkillAddValue> mListData = new List<FB_SkillAddValue>();
        public List<FB_SkillAddValue> ListData
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
        public FB_SkillAddValue GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_SkillAddValue);
        }
        public Dictionary<int, FB_SkillAddValue> GetData()
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
            if (!FB_SkillAddValueContainer.FB_SkillAddValueContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_SkillAddValueContainer.GetRootAsFB_SkillAddValueContainer(bb);
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
