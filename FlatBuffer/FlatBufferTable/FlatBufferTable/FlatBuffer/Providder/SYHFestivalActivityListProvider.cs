using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_SYHFestivalActivityListProvider
    {
        private static FB_SYHFestivalActivityListProvider _Instance;
        public static FB_SYHFestivalActivityListProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_SYHFestivalActivityListProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/SYHFestivalActivityList.txt";
        protected Dictionary<int, FB_SYHFestivalActivityList> mData = new Dictionary<int, FB_SYHFestivalActivityList>();
        private List<FB_SYHFestivalActivityList> mListData = new List<FB_SYHFestivalActivityList>();
        public List<FB_SYHFestivalActivityList> ListData
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
        public FB_SYHFestivalActivityList GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_SYHFestivalActivityList);
        }
        public Dictionary<int, FB_SYHFestivalActivityList> GetData()
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
            if (!FB_SYHFestivalActivityListContainer.FB_SYHFestivalActivityListContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_SYHFestivalActivityListContainer.GetRootAsFB_SYHFestivalActivityListContainer(bb);
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
