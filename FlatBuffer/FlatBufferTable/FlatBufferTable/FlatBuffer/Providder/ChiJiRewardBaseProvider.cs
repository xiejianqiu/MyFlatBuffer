using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_ChiJiRewardBaseProvider
    {
        private static FB_ChiJiRewardBaseProvider _Instance;
        public static FB_ChiJiRewardBaseProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_ChiJiRewardBaseProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/ChiJiRewardBase.txt";
        protected Dictionary<int, FB_ChiJiRewardBase> mData = new Dictionary<int, FB_ChiJiRewardBase>();
        private List<FB_ChiJiRewardBase> mListData = new List<FB_ChiJiRewardBase>();
        public List<FB_ChiJiRewardBase> ListData
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
        public FB_ChiJiRewardBase GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_ChiJiRewardBase);
        }
        public Dictionary<int, FB_ChiJiRewardBase> GetData()
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
            if (!FB_ChiJiRewardBaseContainer.FB_ChiJiRewardBaseContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_ChiJiRewardBaseContainer.GetRootAsFB_ChiJiRewardBaseContainer(bb);
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
