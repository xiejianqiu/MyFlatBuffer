using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_MergeRankShowProvider
    {
        private static FB_MergeRankShowProvider _Instance;
        public static FB_MergeRankShowProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_MergeRankShowProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Client/MergeRankShow.txt";
        protected Dictionary<int, FB_MergeRankShow> mData = new Dictionary<int, FB_MergeRankShow>();
        private List<FB_MergeRankShow> mListData = new List<FB_MergeRankShow>();
        public List<FB_MergeRankShow> ListData
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
        public FB_MergeRankShow GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_MergeRankShow);
        }
        public Dictionary<int, FB_MergeRankShow> GetData()
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
            if (!FB_MergeRankShowContainer.FB_MergeRankShowContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_MergeRankShowContainer.GetRootAsFB_MergeRankShowContainer(bb);
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
