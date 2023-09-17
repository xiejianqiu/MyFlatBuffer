using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_ChongJiGiftProvider
    {
        private static FB_ChongJiGiftProvider _Instance;
        public static FB_ChongJiGiftProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_ChongJiGiftProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/ChongJiGift.txt";
        protected Dictionary<int, FB_ChongJiGift> mData = new Dictionary<int, FB_ChongJiGift>();
        private List<FB_ChongJiGift> mListData = new List<FB_ChongJiGift>();
        public List<FB_ChongJiGift> ListData
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
        public FB_ChongJiGift GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_ChongJiGift);
        }
        public Dictionary<int, FB_ChongJiGift> GetData()
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
            if (!FB_ChongJiGiftContainer.FB_ChongJiGiftContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_ChongJiGiftContainer.GetRootAsFB_ChongJiGiftContainer(bb);
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
