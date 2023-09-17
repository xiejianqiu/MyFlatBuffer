using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_JiLingDecomposeProvider
    {
        private static FB_JiLingDecomposeProvider _Instance;
        public static FB_JiLingDecomposeProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_JiLingDecomposeProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/JiLingDecompose.txt";
        protected Dictionary<int, FB_JiLingDecompose> mData = new Dictionary<int, FB_JiLingDecompose>();
        private List<FB_JiLingDecompose> mListData = new List<FB_JiLingDecompose>();
        public List<FB_JiLingDecompose> ListData
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
        public FB_JiLingDecompose GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_JiLingDecompose);
        }
        public Dictionary<int, FB_JiLingDecompose> GetData()
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
            if (!FB_JiLingDecomposeContainer.FB_JiLingDecomposeContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_JiLingDecomposeContainer.GetRootAsFB_JiLingDecomposeContainer(bb);
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
