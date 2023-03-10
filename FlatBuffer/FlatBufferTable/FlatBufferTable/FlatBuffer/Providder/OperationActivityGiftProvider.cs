using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_OperationActivityGiftProvider
    {
        private static FB_OperationActivityGiftProvider _Instance;
        public static FB_OperationActivityGiftProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_OperationActivityGiftProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/OperationActivityGift.txt";
        protected Dictionary<int, FB_OperationActivityGift> mData = new Dictionary<int, FB_OperationActivityGift>();
        private List<FB_OperationActivityGift> mListData = new List<FB_OperationActivityGift>();
        public List<FB_OperationActivityGift> ListData
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
        public FB_OperationActivityGift GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_OperationActivityGift);
        }
        public Dictionary<int, FB_OperationActivityGift> GetData()
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
            if (!FB_OperationActivityGiftContainer.FB_OperationActivityGiftContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_OperationActivityGiftContainer.GetRootAsFB_OperationActivityGiftContainer(bb);
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
