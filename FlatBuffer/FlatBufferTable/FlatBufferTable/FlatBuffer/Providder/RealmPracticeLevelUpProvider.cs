using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_RealmPracticeLevelUpProvider
    {
        private static FB_RealmPracticeLevelUpProvider _Instance;
        public static FB_RealmPracticeLevelUpProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_RealmPracticeLevelUpProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/RealmPracticeLevelUp.txt";
        protected Dictionary<int, FB_RealmPracticeLevelUp> mData = new Dictionary<int, FB_RealmPracticeLevelUp>();
        private List<FB_RealmPracticeLevelUp> mListData = new List<FB_RealmPracticeLevelUp>();
        public List<FB_RealmPracticeLevelUp> ListData
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
        public FB_RealmPracticeLevelUp GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_RealmPracticeLevelUp);
        }
        public Dictionary<int, FB_RealmPracticeLevelUp> GetData()
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
            if (!FB_RealmPracticeLevelUpContainer.FB_RealmPracticeLevelUpContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_RealmPracticeLevelUpContainer.GetRootAsFB_RealmPracticeLevelUpContainer(bb);
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
