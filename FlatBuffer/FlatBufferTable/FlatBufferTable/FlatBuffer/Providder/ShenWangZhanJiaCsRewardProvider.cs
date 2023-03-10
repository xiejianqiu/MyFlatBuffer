using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_ShenWangZhanJiaCsRewardProvider
    {
        private static FB_ShenWangZhanJiaCsRewardProvider _Instance;
        public static FB_ShenWangZhanJiaCsRewardProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_ShenWangZhanJiaCsRewardProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/ShenWangZhanJiaCsReward.txt";
        protected Dictionary<int, FB_ShenWangZhanJiaCsReward> mData = new Dictionary<int, FB_ShenWangZhanJiaCsReward>();
        private List<FB_ShenWangZhanJiaCsReward> mListData = new List<FB_ShenWangZhanJiaCsReward>();
        public List<FB_ShenWangZhanJiaCsReward> ListData
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
        public FB_ShenWangZhanJiaCsReward GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_ShenWangZhanJiaCsReward);
        }
        public Dictionary<int, FB_ShenWangZhanJiaCsReward> GetData()
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
            if (!FB_ShenWangZhanJiaCsRewardContainer.FB_ShenWangZhanJiaCsRewardContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_ShenWangZhanJiaCsRewardContainer.GetRootAsFB_ShenWangZhanJiaCsRewardContainer(bb);
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
