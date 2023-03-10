using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_JiLingWuHunNingHunProvider
    {
        private static FB_JiLingWuHunNingHunProvider _Instance;
        public static FB_JiLingWuHunNingHunProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_JiLingWuHunNingHunProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/JiLingWuHunNingHun.txt";
        protected Dictionary<int, FB_JiLingWuHunNingHun> mData = new Dictionary<int, FB_JiLingWuHunNingHun>();
        private List<FB_JiLingWuHunNingHun> mListData = new List<FB_JiLingWuHunNingHun>();
        public List<FB_JiLingWuHunNingHun> ListData
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
        public FB_JiLingWuHunNingHun GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_JiLingWuHunNingHun);
        }
        public Dictionary<int, FB_JiLingWuHunNingHun> GetData()
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
            if (!FB_JiLingWuHunNingHunContainer.FB_JiLingWuHunNingHunContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_JiLingWuHunNingHunContainer.GetRootAsFB_JiLingWuHunNingHunContainer(bb);
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
