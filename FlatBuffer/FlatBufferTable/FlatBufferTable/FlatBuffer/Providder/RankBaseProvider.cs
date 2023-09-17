using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_RankBaseProvider
    {
        private static FB_RankBaseProvider _Instance;
        public static FB_RankBaseProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_RankBaseProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/RankBase.txt";
        protected Dictionary<int, FB_RankBase> mData = new Dictionary<int, FB_RankBase>();
        private List<FB_RankBase> mListData = new List<FB_RankBase>();
        public List<FB_RankBase> ListData
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
        public FB_RankBase GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_RankBase);
        }
        public Dictionary<int, FB_RankBase> GetData()
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
            if (!FB_RankBaseContainer.FB_RankBaseContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_RankBaseContainer.GetRootAsFB_RankBaseContainer(bb);
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
