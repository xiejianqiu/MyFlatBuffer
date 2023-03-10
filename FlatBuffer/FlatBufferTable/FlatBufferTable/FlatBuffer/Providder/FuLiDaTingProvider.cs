using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_FuLiDaTingProvider
    {
        private static FB_FuLiDaTingProvider _Instance;
        public static FB_FuLiDaTingProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_FuLiDaTingProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/FuLiDaTing.txt";
        protected Dictionary<int, FB_FuLiDaTing> mData = new Dictionary<int, FB_FuLiDaTing>();
        private List<FB_FuLiDaTing> mListData = new List<FB_FuLiDaTing>();
        public List<FB_FuLiDaTing> ListData
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
        public FB_FuLiDaTing GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_FuLiDaTing);
        }
        public Dictionary<int, FB_FuLiDaTing> GetData()
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
            if (!FB_FuLiDaTingContainer.FB_FuLiDaTingContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_FuLiDaTingContainer.GetRootAsFB_FuLiDaTingContainer(bb);
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
