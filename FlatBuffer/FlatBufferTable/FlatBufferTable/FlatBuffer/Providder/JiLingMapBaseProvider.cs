using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_JiLingMapBaseProvider
    {
        private static FB_JiLingMapBaseProvider _Instance;
        public static FB_JiLingMapBaseProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_JiLingMapBaseProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/JiLingMapBase.txt";
        protected Dictionary<int, FB_JiLingMapBase> mData = new Dictionary<int, FB_JiLingMapBase>();
        private List<FB_JiLingMapBase> mListData = new List<FB_JiLingMapBase>();
        public List<FB_JiLingMapBase> ListData
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
        public FB_JiLingMapBase GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_JiLingMapBase);
        }
        public Dictionary<int, FB_JiLingMapBase> GetData()
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
            if (!FB_JiLingMapBaseContainer.FB_JiLingMapBaseContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_JiLingMapBaseContainer.GetRootAsFB_JiLingMapBaseContainer(bb);
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
