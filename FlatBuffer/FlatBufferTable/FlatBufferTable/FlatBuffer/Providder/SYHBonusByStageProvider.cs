using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_SYHBonusByStageProvider
    {
        private static FB_SYHBonusByStageProvider _Instance;
        public static FB_SYHBonusByStageProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_SYHBonusByStageProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/SYHBonusByStage.txt";
        protected Dictionary<int, FB_SYHBonusByStage> mData = new Dictionary<int, FB_SYHBonusByStage>();
        private List<FB_SYHBonusByStage> mListData = new List<FB_SYHBonusByStage>();
        public List<FB_SYHBonusByStage> ListData
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
        public FB_SYHBonusByStage GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_SYHBonusByStage);
        }
        public Dictionary<int, FB_SYHBonusByStage> GetData()
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
            if (!FB_SYHBonusByStageContainer.FB_SYHBonusByStageContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_SYHBonusByStageContainer.GetRootAsFB_SYHBonusByStageContainer(bb);
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
