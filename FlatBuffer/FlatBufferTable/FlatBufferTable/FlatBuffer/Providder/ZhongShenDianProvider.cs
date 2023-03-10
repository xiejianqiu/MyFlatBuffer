using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_ZhongShenDianProvider
    {
        private static FB_ZhongShenDianProvider _Instance;
        public static FB_ZhongShenDianProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_ZhongShenDianProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/ZhongShenDian.txt";
        protected Dictionary<int, FB_ZhongShenDian> mData = new Dictionary<int, FB_ZhongShenDian>();
        private List<FB_ZhongShenDian> mListData = new List<FB_ZhongShenDian>();
        public List<FB_ZhongShenDian> ListData
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
        public FB_ZhongShenDian GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_ZhongShenDian);
        }
        public Dictionary<int, FB_ZhongShenDian> GetData()
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
            if (!FB_ZhongShenDianContainer.FB_ZhongShenDianContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_ZhongShenDianContainer.GetRootAsFB_ZhongShenDianContainer(bb);
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
