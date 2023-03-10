using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_CSEvalueRewardProvider
    {
        private static FB_CSEvalueRewardProvider _Instance;
        public static FB_CSEvalueRewardProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_CSEvalueRewardProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/CSEvalueReward.txt";
        protected Dictionary<int, FB_CSEvalueReward> mData = new Dictionary<int, FB_CSEvalueReward>();
        private List<FB_CSEvalueReward> mListData = new List<FB_CSEvalueReward>();
        public List<FB_CSEvalueReward> ListData
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
        public FB_CSEvalueReward GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_CSEvalueReward);
        }
        public Dictionary<int, FB_CSEvalueReward> GetData()
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
            if (!FB_CSEvalueRewardContainer.FB_CSEvalueRewardContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_CSEvalueRewardContainer.GetRootAsFB_CSEvalueRewardContainer(bb);
            for (int index = 0; index < data.ItemsLength; index++)
            {
                var item = data.GetItems(index);
                mData.Add(item.Id, item);
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
