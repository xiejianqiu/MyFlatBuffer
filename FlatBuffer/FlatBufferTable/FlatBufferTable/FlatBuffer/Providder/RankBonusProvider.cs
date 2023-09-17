using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_RankBonusProvider
    {
        private static FB_RankBonusProvider _Instance;
        public static FB_RankBonusProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_RankBonusProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/RankBonus.txt";
        protected Dictionary<int, FB_RankBonus> mData = new Dictionary<int, FB_RankBonus>();
        private List<FB_RankBonus> mListData = new List<FB_RankBonus>();
        public List<FB_RankBonus> ListData
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
        public FB_RankBonus GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_RankBonus);
        }
        public Dictionary<int, FB_RankBonus> GetData()
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
            if (!FB_RankBonusContainer.FB_RankBonusContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_RankBonusContainer.GetRootAsFB_RankBonusContainer(bb);
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
