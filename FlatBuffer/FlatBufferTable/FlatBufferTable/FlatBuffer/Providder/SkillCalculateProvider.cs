using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_SkillCalculateProvider
    {
        private static FB_SkillCalculateProvider _Instance;
        public static FB_SkillCalculateProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_SkillCalculateProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/SkillCalculate.txt";
        protected Dictionary<int, FB_SkillCalculate> mData = new Dictionary<int, FB_SkillCalculate>();
        private List<FB_SkillCalculate> mListData = new List<FB_SkillCalculate>();
        public List<FB_SkillCalculate> ListData
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
        public FB_SkillCalculate GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_SkillCalculate);
        }
        public Dictionary<int, FB_SkillCalculate> GetData()
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
            if (!FB_SkillCalculateContainer.FB_SkillCalculateContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_SkillCalculateContainer.GetRootAsFB_SkillCalculateContainer(bb);
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
