using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_LingBaoQiLingProvider
    {
        private static FB_LingBaoQiLingProvider _Instance;
        public static FB_LingBaoQiLingProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_LingBaoQiLingProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/LingBaoQiLing.txt";
        protected Dictionary<int, FB_LingBaoQiLing> mData = new Dictionary<int, FB_LingBaoQiLing>();
        private List<FB_LingBaoQiLing> mListData = new List<FB_LingBaoQiLing>();
        public List<FB_LingBaoQiLing> ListData
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
        public FB_LingBaoQiLing GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_LingBaoQiLing);
        }
        public Dictionary<int, FB_LingBaoQiLing> GetData()
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
            if (!FB_LingBaoQiLingContainer.FB_LingBaoQiLingContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_LingBaoQiLingContainer.GetRootAsFB_LingBaoQiLingContainer(bb);
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
