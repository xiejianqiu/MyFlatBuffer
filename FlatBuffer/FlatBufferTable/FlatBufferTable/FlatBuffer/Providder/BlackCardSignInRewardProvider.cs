using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_BlackCardSignInRewardProvider
    {
        private static FB_BlackCardSignInRewardProvider _Instance;
        public static FB_BlackCardSignInRewardProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_BlackCardSignInRewardProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/BlackCardSignInReward.txt";
        protected Dictionary<int, FB_BlackCardSignInReward> mData = new Dictionary<int, FB_BlackCardSignInReward>();
        private List<FB_BlackCardSignInReward> mListData = new List<FB_BlackCardSignInReward>();
        public List<FB_BlackCardSignInReward> ListData
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
        public FB_BlackCardSignInReward GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_BlackCardSignInReward);
        }
        public Dictionary<int, FB_BlackCardSignInReward> GetData()
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
            if (!FB_BlackCardSignInRewardContainer.FB_BlackCardSignInRewardContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_BlackCardSignInRewardContainer.GetRootAsFB_BlackCardSignInRewardContainer(bb);
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
