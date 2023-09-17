using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_MarryGiftInfoProvider
    {
        private static FB_MarryGiftInfoProvider _Instance;
        public static FB_MarryGiftInfoProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_MarryGiftInfoProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/MarryGiftInfo.txt";
        protected Dictionary<int, FB_MarryGiftInfo> mData = new Dictionary<int, FB_MarryGiftInfo>();
        private List<FB_MarryGiftInfo> mListData = new List<FB_MarryGiftInfo>();
        public List<FB_MarryGiftInfo> ListData
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
        public FB_MarryGiftInfo GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_MarryGiftInfo);
        }
        public Dictionary<int, FB_MarryGiftInfo> GetData()
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
            if (!FB_MarryGiftInfoContainer.FB_MarryGiftInfoContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_MarryGiftInfoContainer.GetRootAsFB_MarryGiftInfoContainer(bb);
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
