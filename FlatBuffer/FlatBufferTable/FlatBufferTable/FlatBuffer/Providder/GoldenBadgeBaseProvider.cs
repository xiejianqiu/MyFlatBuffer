using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_GoldenBadgeBaseProvider
    {
        private static FB_GoldenBadgeBaseProvider _Instance;
        public static FB_GoldenBadgeBaseProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_GoldenBadgeBaseProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/GoldenBadgeBase.txt";
        protected Dictionary<int, FB_GoldenBadgeBase> mData = new Dictionary<int, FB_GoldenBadgeBase>();
        private List<FB_GoldenBadgeBase> mListData = new List<FB_GoldenBadgeBase>();
        public List<FB_GoldenBadgeBase> ListData
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
        public FB_GoldenBadgeBase GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_GoldenBadgeBase);
        }
        public Dictionary<int, FB_GoldenBadgeBase> GetData()
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
            if (!FB_GoldenBadgeBaseContainer.FB_GoldenBadgeBaseContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_GoldenBadgeBaseContainer.GetRootAsFB_GoldenBadgeBaseContainer(bb);
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
