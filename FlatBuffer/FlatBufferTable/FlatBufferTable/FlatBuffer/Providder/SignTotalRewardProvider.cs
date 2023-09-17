using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_SignTotalRewardProvider
    {
        private static FB_SignTotalRewardProvider _Instance;
        public static FB_SignTotalRewardProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_SignTotalRewardProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/SignTotalReward.txt";
        protected Dictionary<int, FB_SignTotalReward> mData = new Dictionary<int, FB_SignTotalReward>();
        private List<FB_SignTotalReward> mListData = new List<FB_SignTotalReward>();
        public List<FB_SignTotalReward> ListData
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
        public FB_SignTotalReward GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_SignTotalReward);
        }
        public Dictionary<int, FB_SignTotalReward> GetData()
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
            if (!FB_SignTotalRewardContainer.FB_SignTotalRewardContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_SignTotalRewardContainer.GetRootAsFB_SignTotalRewardContainer(bb);
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
