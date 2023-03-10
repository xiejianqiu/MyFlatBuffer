using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_BlackCardTickProvider
    {
        private static FB_BlackCardTickProvider _Instance;
        public static FB_BlackCardTickProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_BlackCardTickProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/BlackCardTick.txt";
        protected Dictionary<int, FB_BlackCardTick> mData = new Dictionary<int, FB_BlackCardTick>();
        private List<FB_BlackCardTick> mListData = new List<FB_BlackCardTick>();
        public List<FB_BlackCardTick> ListData
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
        public FB_BlackCardTick GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_BlackCardTick);
        }
        public Dictionary<int, FB_BlackCardTick> GetData()
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
            if (!FB_BlackCardTickContainer.FB_BlackCardTickContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_BlackCardTickContainer.GetRootAsFB_BlackCardTickContainer(bb);
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
