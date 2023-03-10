using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_MissionGuideProvider
    {
        private static FB_MissionGuideProvider _Instance;
        public static FB_MissionGuideProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_MissionGuideProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/MissionGuide.txt";
        protected Dictionary<int, FB_MissionGuide> mData = new Dictionary<int, FB_MissionGuide>();
        private List<FB_MissionGuide> mListData = new List<FB_MissionGuide>();
        public List<FB_MissionGuide> ListData
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
        public FB_MissionGuide GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_MissionGuide);
        }
        public Dictionary<int, FB_MissionGuide> GetData()
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
            if (!FB_MissionGuideContainer.FB_MissionGuideContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_MissionGuideContainer.GetRootAsFB_MissionGuideContainer(bb);
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
