using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_AchievementClassProvider
    {
        private static FB_AchievementClassProvider _Instance;
        public static FB_AchievementClassProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_AchievementClassProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/AchievementClass.txt";
        protected Dictionary<int, FB_AchievementClass> mData = new Dictionary<int, FB_AchievementClass>();
        private List<FB_AchievementClass> mListData = new List<FB_AchievementClass>();
        public List<FB_AchievementClass> ListData
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
        public FB_AchievementClass GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_AchievementClass);
        }
        public Dictionary<int, FB_AchievementClass> GetData()
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
            if (!FB_AchievementClassContainer.FB_AchievementClassContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_AchievementClassContainer.GetRootAsFB_AchievementClassContainer(bb);
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
