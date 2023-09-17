using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_ActivityPrayShowProvider
    {
        private static FB_ActivityPrayShowProvider _Instance;
        public static FB_ActivityPrayShowProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_ActivityPrayShowProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Client/ActivityPrayShow.txt";
        protected Dictionary<int, FB_ActivityPrayShow> mData = new Dictionary<int, FB_ActivityPrayShow>();
        private List<FB_ActivityPrayShow> mListData = new List<FB_ActivityPrayShow>();
        public List<FB_ActivityPrayShow> ListData
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
        public FB_ActivityPrayShow GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_ActivityPrayShow);
        }
        public Dictionary<int, FB_ActivityPrayShow> GetData()
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
            if (!FB_ActivityPrayShowContainer.FB_ActivityPrayShowContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_ActivityPrayShowContainer.GetRootAsFB_ActivityPrayShowContainer(bb);
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
