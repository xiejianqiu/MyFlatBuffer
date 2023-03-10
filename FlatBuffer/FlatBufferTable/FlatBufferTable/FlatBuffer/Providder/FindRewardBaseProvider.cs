using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_FindRewardBaseProvider
    {
        private static FB_FindRewardBaseProvider _Instance;
        public static FB_FindRewardBaseProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_FindRewardBaseProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/FindRewardBase.txt";
        protected Dictionary<int, FB_FindRewardBase> mData = new Dictionary<int, FB_FindRewardBase>();
        private List<FB_FindRewardBase> mListData = new List<FB_FindRewardBase>();
        public List<FB_FindRewardBase> ListData
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
        public FB_FindRewardBase GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_FindRewardBase);
        }
        public Dictionary<int, FB_FindRewardBase> GetData()
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
            if (!FB_FindRewardBaseContainer.FB_FindRewardBaseContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_FindRewardBaseContainer.GetRootAsFB_FindRewardBaseContainer(bb);
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