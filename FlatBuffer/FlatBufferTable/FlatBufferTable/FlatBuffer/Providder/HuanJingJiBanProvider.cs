using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_HuanJingJiBanProvider
    {
        private static FB_HuanJingJiBanProvider _Instance;
        public static FB_HuanJingJiBanProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_HuanJingJiBanProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/HuanJingJiBan.txt";
        protected Dictionary<int, FB_HuanJingJiBan> mData = new Dictionary<int, FB_HuanJingJiBan>();
        private List<FB_HuanJingJiBan> mListData = new List<FB_HuanJingJiBan>();
        public List<FB_HuanJingJiBan> ListData
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
        public FB_HuanJingJiBan GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_HuanJingJiBan);
        }
        public Dictionary<int, FB_HuanJingJiBan> GetData()
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
            if (!FB_HuanJingJiBanContainer.FB_HuanJingJiBanContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_HuanJingJiBanContainer.GetRootAsFB_HuanJingJiBanContainer(bb);
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
