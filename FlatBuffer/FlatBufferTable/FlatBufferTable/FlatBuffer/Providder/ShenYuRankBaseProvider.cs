using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_ShenYuRankBaseProvider
    {
        private static FB_ShenYuRankBaseProvider _Instance;
        public static FB_ShenYuRankBaseProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_ShenYuRankBaseProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Client/ShenYuRankBase.txt";
        protected Dictionary<int, FB_ShenYuRankBase> mData = new Dictionary<int, FB_ShenYuRankBase>();
        private List<FB_ShenYuRankBase> mListData = new List<FB_ShenYuRankBase>();
        public List<FB_ShenYuRankBase> ListData
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
        public FB_ShenYuRankBase GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_ShenYuRankBase);
        }
        public Dictionary<int, FB_ShenYuRankBase> GetData()
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
            if (!FB_ShenYuRankBaseContainer.FB_ShenYuRankBaseContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_ShenYuRankBaseContainer.GetRootAsFB_ShenYuRankBaseContainer(bb);
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
