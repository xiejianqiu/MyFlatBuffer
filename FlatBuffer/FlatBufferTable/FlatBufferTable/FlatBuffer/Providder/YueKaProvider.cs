using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_YueKaProvider
    {
        private static FB_YueKaProvider _Instance;
        public static FB_YueKaProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_YueKaProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/YueKa.txt";
        protected Dictionary<int, FB_YueKa> mData = new Dictionary<int, FB_YueKa>();
        private List<FB_YueKa> mListData = new List<FB_YueKa>();
        public List<FB_YueKa> ListData
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
        public FB_YueKa GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_YueKa);
        }
        public Dictionary<int, FB_YueKa> GetData()
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
            if (!FB_YueKaContainer.FB_YueKaContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_YueKaContainer.GetRootAsFB_YueKaContainer(bb);
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
