using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_JieYuanSuitInfoProvider
    {
        private static FB_JieYuanSuitInfoProvider _Instance;
        public static FB_JieYuanSuitInfoProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_JieYuanSuitInfoProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/JieYuanSuitInfo.txt";
        protected Dictionary<int, FB_JieYuanSuitInfo> mData = new Dictionary<int, FB_JieYuanSuitInfo>();
        private List<FB_JieYuanSuitInfo> mListData = new List<FB_JieYuanSuitInfo>();
        public List<FB_JieYuanSuitInfo> ListData
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
        public FB_JieYuanSuitInfo GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_JieYuanSuitInfo);
        }
        public Dictionary<int, FB_JieYuanSuitInfo> GetData()
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
            if (!FB_JieYuanSuitInfoContainer.FB_JieYuanSuitInfoContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_JieYuanSuitInfoContainer.GetRootAsFB_JieYuanSuitInfoContainer(bb);
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
