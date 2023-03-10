using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_ShenWangYouLeChangProvider
    {
        private static FB_ShenWangYouLeChangProvider _Instance;
        public static FB_ShenWangYouLeChangProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_ShenWangYouLeChangProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Client/ShenWangYouLeChang.txt";
        protected Dictionary<int, FB_ShenWangYouLeChang> mData = new Dictionary<int, FB_ShenWangYouLeChang>();
        private List<FB_ShenWangYouLeChang> mListData = new List<FB_ShenWangYouLeChang>();
        public List<FB_ShenWangYouLeChang> ListData
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
        public FB_ShenWangYouLeChang GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_ShenWangYouLeChang);
        }
        public Dictionary<int, FB_ShenWangYouLeChang> GetData()
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
            if (!FB_ShenWangYouLeChangContainer.FB_ShenWangYouLeChangContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_ShenWangYouLeChangContainer.GetRootAsFB_ShenWangYouLeChangContainer(bb);
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
