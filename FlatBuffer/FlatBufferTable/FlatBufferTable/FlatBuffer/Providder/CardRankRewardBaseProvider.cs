using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_CardRankRewardBaseProvider
    {
        private static FB_CardRankRewardBaseProvider _Instance;
        public static FB_CardRankRewardBaseProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_CardRankRewardBaseProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/CardRankRewardBase.txt";
        protected Dictionary<int, FB_CardRankRewardBase> mData = new Dictionary<int, FB_CardRankRewardBase>();
        private List<FB_CardRankRewardBase> mListData = new List<FB_CardRankRewardBase>();
        public List<FB_CardRankRewardBase> ListData
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
        public FB_CardRankRewardBase GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_CardRankRewardBase);
        }
        public Dictionary<int, FB_CardRankRewardBase> GetData()
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
            if (!FB_CardRankRewardBaseContainer.FB_CardRankRewardBaseContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_CardRankRewardBaseContainer.GetRootAsFB_CardRankRewardBaseContainer(bb);
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
