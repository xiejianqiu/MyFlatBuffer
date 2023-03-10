using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_AchievementBaseProvider
    {
        private static FB_AchievementBaseProvider _Instance;
        public static FB_AchievementBaseProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_AchievementBaseProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/AchievementBase.txt";
        protected Dictionary<int, FB_AchievementBase> mData = new Dictionary<int, FB_AchievementBase>();
        private List<FB_AchievementBase> mListData = new List<FB_AchievementBase>();
        public List<FB_AchievementBase> ListData
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
        public FB_AchievementBase GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_AchievementBase);
        }
        public Dictionary<int, FB_AchievementBase> GetData()
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
            if (!FB_AchievementBaseContainer.FB_AchievementBaseContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_AchievementBaseContainer.GetRootAsFB_AchievementBaseContainer(bb);
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
