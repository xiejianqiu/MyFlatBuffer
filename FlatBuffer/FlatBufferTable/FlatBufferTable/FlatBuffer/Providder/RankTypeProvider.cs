using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_RankTypeProvider
    {
        private static FB_RankTypeProvider _Instance;
        public static FB_RankTypeProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_RankTypeProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Client/RankType.txt";
        protected Dictionary<int, FB_RankType> mData = new Dictionary<int, FB_RankType>();
        private List<FB_RankType> mListData = new List<FB_RankType>();
        public List<FB_RankType> ListData
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
        public FB_RankType GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_RankType);
        }
        public Dictionary<int, FB_RankType> GetData()
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
            if (!FB_RankTypeContainer.FB_RankTypeContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_RankTypeContainer.GetRootAsFB_RankTypeContainer(bb);
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
