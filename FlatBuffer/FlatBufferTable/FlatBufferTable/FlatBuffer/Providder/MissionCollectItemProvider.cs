using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_MissionCollectItemProvider
    {
        private static FB_MissionCollectItemProvider _Instance;
        public static FB_MissionCollectItemProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_MissionCollectItemProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/MissionCollectItem.txt";
        protected Dictionary<int, FB_MissionCollectItem> mData = new Dictionary<int, FB_MissionCollectItem>();
        private List<FB_MissionCollectItem> mListData = new List<FB_MissionCollectItem>();
        public List<FB_MissionCollectItem> ListData
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
        public FB_MissionCollectItem GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_MissionCollectItem);
        }
        public Dictionary<int, FB_MissionCollectItem> GetData()
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
            if (!FB_MissionCollectItemContainer.FB_MissionCollectItemContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_MissionCollectItemContainer.GetRootAsFB_MissionCollectItemContainer(bb);
            for (int index = 0; index < data.ItemsLength; index++)
            {
                var item = data.GetItems(index);
                mData.Add(item.Index, item);
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
