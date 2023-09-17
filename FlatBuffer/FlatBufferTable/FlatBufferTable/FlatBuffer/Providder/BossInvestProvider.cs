using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_BossInvestProvider
    {
        private static FB_BossInvestProvider _Instance;
        public static FB_BossInvestProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_BossInvestProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/BossInvest.txt";
        protected Dictionary<int, FB_BossInvest> mData = new Dictionary<int, FB_BossInvest>();
        private List<FB_BossInvest> mListData = new List<FB_BossInvest>();
        public List<FB_BossInvest> ListData
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
        public FB_BossInvest GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_BossInvest);
        }
        public Dictionary<int, FB_BossInvest> GetData()
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
            if (!FB_BossInvestContainer.FB_BossInvestContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_BossInvestContainer.GetRootAsFB_BossInvestContainer(bb);
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
