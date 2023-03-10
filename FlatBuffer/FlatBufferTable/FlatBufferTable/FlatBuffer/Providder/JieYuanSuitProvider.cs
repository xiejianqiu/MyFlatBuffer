using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_JieYuanSuitProvider
    {
        private static FB_JieYuanSuitProvider _Instance;
        public static FB_JieYuanSuitProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_JieYuanSuitProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/JieYuanSuit.txt";
        protected Dictionary<int, FB_JieYuanSuit> mData = new Dictionary<int, FB_JieYuanSuit>();
        private List<FB_JieYuanSuit> mListData = new List<FB_JieYuanSuit>();
        public List<FB_JieYuanSuit> ListData
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
        public FB_JieYuanSuit GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_JieYuanSuit);
        }
        public Dictionary<int, FB_JieYuanSuit> GetData()
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
            if (!FB_JieYuanSuitContainer.FB_JieYuanSuitContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_JieYuanSuitContainer.GetRootAsFB_JieYuanSuitContainer(bb);
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
