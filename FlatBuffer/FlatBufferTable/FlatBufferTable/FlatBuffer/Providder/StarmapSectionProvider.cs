using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_StarmapSectionProvider
    {
        private static FB_StarmapSectionProvider _Instance;
        public static FB_StarmapSectionProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_StarmapSectionProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/StarmapSection.txt";
        protected Dictionary<int, FB_StarmapSection> mData = new Dictionary<int, FB_StarmapSection>();
        private List<FB_StarmapSection> mListData = new List<FB_StarmapSection>();
        public List<FB_StarmapSection> ListData
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
        public FB_StarmapSection GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_StarmapSection);
        }
        public Dictionary<int, FB_StarmapSection> GetData()
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
            if (!FB_StarmapSectionContainer.FB_StarmapSectionContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_StarmapSectionContainer.GetRootAsFB_StarmapSectionContainer(bb);
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
