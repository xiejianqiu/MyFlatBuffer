using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_BossInvestTypeProvider
    {
        private static FB_BossInvestTypeProvider _Instance;
        public static FB_BossInvestTypeProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_BossInvestTypeProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/BossInvestType.txt";
        protected Dictionary<int, FB_BossInvestType> mData = new Dictionary<int, FB_BossInvestType>();
        private List<FB_BossInvestType> mListData = new List<FB_BossInvestType>();
        public List<FB_BossInvestType> ListData
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
        public FB_BossInvestType GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_BossInvestType);
        }
        public Dictionary<int, FB_BossInvestType> GetData()
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
            if (!FB_BossInvestTypeContainer.FB_BossInvestTypeContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_BossInvestTypeContainer.GetRootAsFB_BossInvestTypeContainer(bb);
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
