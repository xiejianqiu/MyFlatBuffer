using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_SYHJuBaoPenRankingProvider
    {
        private static FB_SYHJuBaoPenRankingProvider _Instance;
        public static FB_SYHJuBaoPenRankingProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_SYHJuBaoPenRankingProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/SYHJuBaoPenRanking.txt";
        protected Dictionary<int, FB_SYHJuBaoPenRanking> mData = new Dictionary<int, FB_SYHJuBaoPenRanking>();
        private List<FB_SYHJuBaoPenRanking> mListData = new List<FB_SYHJuBaoPenRanking>();
        public List<FB_SYHJuBaoPenRanking> ListData
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
        public FB_SYHJuBaoPenRanking GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_SYHJuBaoPenRanking);
        }
        public Dictionary<int, FB_SYHJuBaoPenRanking> GetData()
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
            if (!FB_SYHJuBaoPenRankingContainer.FB_SYHJuBaoPenRankingContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_SYHJuBaoPenRankingContainer.GetRootAsFB_SYHJuBaoPenRankingContainer(bb);
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
