using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_CardJiBanActivateRewardProvider
    {
        private static FB_CardJiBanActivateRewardProvider _Instance;
        public static FB_CardJiBanActivateRewardProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_CardJiBanActivateRewardProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/CardJiBanActivateReward.txt";
        protected Dictionary<int, FB_CardJiBanActivateReward> mData = new Dictionary<int, FB_CardJiBanActivateReward>();
        private List<FB_CardJiBanActivateReward> mListData = new List<FB_CardJiBanActivateReward>();
        public List<FB_CardJiBanActivateReward> ListData
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
        public FB_CardJiBanActivateReward GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_CardJiBanActivateReward);
        }
        public Dictionary<int, FB_CardJiBanActivateReward> GetData()
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
            if (!FB_CardJiBanActivateRewardContainer.FB_CardJiBanActivateRewardContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_CardJiBanActivateRewardContainer.GetRootAsFB_CardJiBanActivateRewardContainer(bb);
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
