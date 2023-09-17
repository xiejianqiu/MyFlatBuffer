using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_HunJiangJuHunProvider
    {
        private static FB_HunJiangJuHunProvider _Instance;
        public static FB_HunJiangJuHunProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_HunJiangJuHunProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/HunJiangJuHun.txt";
        protected Dictionary<int, FB_HunJiangJuHun> mData = new Dictionary<int, FB_HunJiangJuHun>();
        private List<FB_HunJiangJuHun> mListData = new List<FB_HunJiangJuHun>();
        public List<FB_HunJiangJuHun> ListData
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
        public FB_HunJiangJuHun GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_HunJiangJuHun);
        }
        public Dictionary<int, FB_HunJiangJuHun> GetData()
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
            if (!FB_HunJiangJuHunContainer.FB_HunJiangJuHunContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_HunJiangJuHunContainer.GetRootAsFB_HunJiangJuHunContainer(bb);
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
