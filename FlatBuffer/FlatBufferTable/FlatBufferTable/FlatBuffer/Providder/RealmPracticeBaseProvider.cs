using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_RealmPracticeBaseProvider
    {
        private static FB_RealmPracticeBaseProvider _Instance;
        public static FB_RealmPracticeBaseProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_RealmPracticeBaseProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/RealmPracticeBase.txt";
        protected Dictionary<int, FB_RealmPracticeBase> mData = new Dictionary<int, FB_RealmPracticeBase>();
        private List<FB_RealmPracticeBase> mListData = new List<FB_RealmPracticeBase>();
        public List<FB_RealmPracticeBase> ListData
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
        public FB_RealmPracticeBase GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_RealmPracticeBase);
        }
        public Dictionary<int, FB_RealmPracticeBase> GetData()
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
            if (!FB_RealmPracticeBaseContainer.FB_RealmPracticeBaseContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_RealmPracticeBaseContainer.GetRootAsFB_RealmPracticeBaseContainer(bb);
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
