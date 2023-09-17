using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_XingYunGuideEventProvider
    {
        private static FB_XingYunGuideEventProvider _Instance;
        public static FB_XingYunGuideEventProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_XingYunGuideEventProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/XingYunGuideEvent.txt";
        protected Dictionary<int, FB_XingYunGuideEvent> mData = new Dictionary<int, FB_XingYunGuideEvent>();
        private List<FB_XingYunGuideEvent> mListData = new List<FB_XingYunGuideEvent>();
        public List<FB_XingYunGuideEvent> ListData
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
        public FB_XingYunGuideEvent GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_XingYunGuideEvent);
        }
        public Dictionary<int, FB_XingYunGuideEvent> GetData()
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
            if (!FB_XingYunGuideEventContainer.FB_XingYunGuideEventContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_XingYunGuideEventContainer.GetRootAsFB_XingYunGuideEventContainer(bb);
            for (int index = 0; index < data.ItemsLength; index++)
            {
                var item = data.GetItems(index);
                mData.Add(item.EventId, item);
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
