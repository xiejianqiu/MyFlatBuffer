using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_BloodMixLevelProvider
    {
        private static FB_BloodMixLevelProvider _Instance;
        public static FB_BloodMixLevelProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_BloodMixLevelProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/BloodMixLevel.txt";
        protected Dictionary<int, FB_BloodMixLevel> mData = new Dictionary<int, FB_BloodMixLevel>();
        private List<FB_BloodMixLevel> mListData = new List<FB_BloodMixLevel>();
        public List<FB_BloodMixLevel> ListData
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
        public FB_BloodMixLevel GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_BloodMixLevel);
        }
        public Dictionary<int, FB_BloodMixLevel> GetData()
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
            if (!FB_BloodMixLevelContainer.FB_BloodMixLevelContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_BloodMixLevelContainer.GetRootAsFB_BloodMixLevelContainer(bb);
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
