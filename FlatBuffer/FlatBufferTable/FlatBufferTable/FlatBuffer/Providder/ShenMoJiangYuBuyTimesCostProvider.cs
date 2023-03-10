using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_ShenMoJiangYuBuyTimesCostProvider
    {
        private static FB_ShenMoJiangYuBuyTimesCostProvider _Instance;
        public static FB_ShenMoJiangYuBuyTimesCostProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_ShenMoJiangYuBuyTimesCostProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/ShenMoJiangYuBuyTimesCost.txt";
        protected Dictionary<int, FB_ShenMoJiangYuBuyTimesCost> mData = new Dictionary<int, FB_ShenMoJiangYuBuyTimesCost>();
        private List<FB_ShenMoJiangYuBuyTimesCost> mListData = new List<FB_ShenMoJiangYuBuyTimesCost>();
        public List<FB_ShenMoJiangYuBuyTimesCost> ListData
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
        public FB_ShenMoJiangYuBuyTimesCost GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_ShenMoJiangYuBuyTimesCost);
        }
        public Dictionary<int, FB_ShenMoJiangYuBuyTimesCost> GetData()
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
            if (!FB_ShenMoJiangYuBuyTimesCostContainer.FB_ShenMoJiangYuBuyTimesCostContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_ShenMoJiangYuBuyTimesCostContainer.GetRootAsFB_ShenMoJiangYuBuyTimesCostContainer(bb);
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
