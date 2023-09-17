using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_SYHJuBaoPenRewardProvider
    {
        private static FB_SYHJuBaoPenRewardProvider _Instance;
        public static FB_SYHJuBaoPenRewardProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_SYHJuBaoPenRewardProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/SYHJuBaoPenReward.txt";
        protected Dictionary<int, FB_SYHJuBaoPenReward> mData = new Dictionary<int, FB_SYHJuBaoPenReward>();
        private List<FB_SYHJuBaoPenReward> mListData = new List<FB_SYHJuBaoPenReward>();
        public List<FB_SYHJuBaoPenReward> ListData
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
        public FB_SYHJuBaoPenReward GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_SYHJuBaoPenReward);
        }
        public Dictionary<int, FB_SYHJuBaoPenReward> GetData()
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
            if (!FB_SYHJuBaoPenRewardContainer.FB_SYHJuBaoPenRewardContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_SYHJuBaoPenRewardContainer.GetRootAsFB_SYHJuBaoPenRewardContainer(bb);
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
