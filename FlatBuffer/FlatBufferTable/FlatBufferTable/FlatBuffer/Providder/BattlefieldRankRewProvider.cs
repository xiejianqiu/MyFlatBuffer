using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_BattlefieldRankRewProvider
    {
        private static FB_BattlefieldRankRewProvider _Instance;
        public static FB_BattlefieldRankRewProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_BattlefieldRankRewProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/BattlefieldRankRew.txt";
        protected Dictionary<int, FB_BattlefieldRankRew> mData = new Dictionary<int, FB_BattlefieldRankRew>();
        private List<FB_BattlefieldRankRew> mListData = new List<FB_BattlefieldRankRew>();
        public List<FB_BattlefieldRankRew> ListData
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
        public FB_BattlefieldRankRew GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_BattlefieldRankRew);
        }
        public Dictionary<int, FB_BattlefieldRankRew> GetData()
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
            if (!FB_BattlefieldRankRewContainer.FB_BattlefieldRankRewContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_BattlefieldRankRewContainer.GetRootAsFB_BattlefieldRankRewContainer(bb);
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
