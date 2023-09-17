using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_SignInRewardProvider
    {
        private static FB_SignInRewardProvider _Instance;
        public static FB_SignInRewardProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_SignInRewardProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/SignInReward.txt";
        protected Dictionary<int, FB_SignInReward> mData = new Dictionary<int, FB_SignInReward>();
        private List<FB_SignInReward> mListData = new List<FB_SignInReward>();
        public List<FB_SignInReward> ListData
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
        public FB_SignInReward GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_SignInReward);
        }
        public Dictionary<int, FB_SignInReward> GetData()
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
            if (!FB_SignInRewardContainer.FB_SignInRewardContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_SignInRewardContainer.GetRootAsFB_SignInRewardContainer(bb);
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
