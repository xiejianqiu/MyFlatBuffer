using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_SYHZaDanPingGuoNumRewardProvider
    {
        private static FB_SYHZaDanPingGuoNumRewardProvider _Instance;
        public static FB_SYHZaDanPingGuoNumRewardProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_SYHZaDanPingGuoNumRewardProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/SYHZaDanPingGuoNumReward.txt";
        protected Dictionary<int, FB_SYHZaDanPingGuoNumReward> mData = new Dictionary<int, FB_SYHZaDanPingGuoNumReward>();
        private List<FB_SYHZaDanPingGuoNumReward> mListData = new List<FB_SYHZaDanPingGuoNumReward>();
        public List<FB_SYHZaDanPingGuoNumReward> ListData
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
        public FB_SYHZaDanPingGuoNumReward GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_SYHZaDanPingGuoNumReward);
        }
        public Dictionary<int, FB_SYHZaDanPingGuoNumReward> GetData()
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
            if (!FB_SYHZaDanPingGuoNumRewardContainer.FB_SYHZaDanPingGuoNumRewardContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_SYHZaDanPingGuoNumRewardContainer.GetRootAsFB_SYHZaDanPingGuoNumRewardContainer(bb);
            for (int index = 0; index < data.ItemsLength; index++)
            {
                var item = data.GetItems(index);
                mData.Add(item.id, item);
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
