using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_CharmLoveRankRewardBaseProvider
    {
        private static FB_CharmLoveRankRewardBaseProvider _Instance;
        public static FB_CharmLoveRankRewardBaseProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_CharmLoveRankRewardBaseProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/CharmLoveRankRewardBase.txt";
        protected Dictionary<int, FB_CharmLoveRankRewardBase> mData = new Dictionary<int, FB_CharmLoveRankRewardBase>();
        private List<FB_CharmLoveRankRewardBase> mListData = new List<FB_CharmLoveRankRewardBase>();
        public List<FB_CharmLoveRankRewardBase> ListData
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
        public FB_CharmLoveRankRewardBase GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_CharmLoveRankRewardBase);
        }
        public Dictionary<int, FB_CharmLoveRankRewardBase> GetData()
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
            if (!FB_CharmLoveRankRewardBaseContainer.FB_CharmLoveRankRewardBaseContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_CharmLoveRankRewardBaseContainer.GetRootAsFB_CharmLoveRankRewardBaseContainer(bb);
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
