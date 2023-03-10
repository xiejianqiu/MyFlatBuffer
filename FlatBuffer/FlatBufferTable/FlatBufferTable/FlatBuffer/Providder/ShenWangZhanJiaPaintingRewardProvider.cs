using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_ShenWangZhanJiaPaintingRewardProvider
    {
        private static FB_ShenWangZhanJiaPaintingRewardProvider _Instance;
        public static FB_ShenWangZhanJiaPaintingRewardProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_ShenWangZhanJiaPaintingRewardProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/ShenWangZhanJiaPaintingReward.txt";
        protected Dictionary<int, FB_ShenWangZhanJiaPaintingReward> mData = new Dictionary<int, FB_ShenWangZhanJiaPaintingReward>();
        private List<FB_ShenWangZhanJiaPaintingReward> mListData = new List<FB_ShenWangZhanJiaPaintingReward>();
        public List<FB_ShenWangZhanJiaPaintingReward> ListData
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
        public FB_ShenWangZhanJiaPaintingReward GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_ShenWangZhanJiaPaintingReward);
        }
        public Dictionary<int, FB_ShenWangZhanJiaPaintingReward> GetData()
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
            if (!FB_ShenWangZhanJiaPaintingRewardContainer.FB_ShenWangZhanJiaPaintingRewardContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_ShenWangZhanJiaPaintingRewardContainer.GetRootAsFB_ShenWangZhanJiaPaintingRewardContainer(bb);
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
