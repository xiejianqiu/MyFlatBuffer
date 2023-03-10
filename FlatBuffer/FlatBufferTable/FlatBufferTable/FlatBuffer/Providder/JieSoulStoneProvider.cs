using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_JieSoulStoneProvider
    {
        private static FB_JieSoulStoneProvider _Instance;
        public static FB_JieSoulStoneProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_JieSoulStoneProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/JieSoulStone.txt";
        protected Dictionary<int, FB_JieSoulStone> mData = new Dictionary<int, FB_JieSoulStone>();
        private List<FB_JieSoulStone> mListData = new List<FB_JieSoulStone>();
        public List<FB_JieSoulStone> ListData
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
        public FB_JieSoulStone GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_JieSoulStone);
        }
        public Dictionary<int, FB_JieSoulStone> GetData()
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
            if (!FB_JieSoulStoneContainer.FB_JieSoulStoneContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_JieSoulStoneContainer.GetRootAsFB_JieSoulStoneContainer(bb);
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
