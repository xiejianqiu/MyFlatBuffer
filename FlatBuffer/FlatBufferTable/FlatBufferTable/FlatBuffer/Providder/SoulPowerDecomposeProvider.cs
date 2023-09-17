using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_SoulPowerDecomposeProvider
    {
        private static FB_SoulPowerDecomposeProvider _Instance;
        public static FB_SoulPowerDecomposeProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_SoulPowerDecomposeProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/SoulPowerDecompose.txt";
        protected Dictionary<int, FB_SoulPowerDecompose> mData = new Dictionary<int, FB_SoulPowerDecompose>();
        private List<FB_SoulPowerDecompose> mListData = new List<FB_SoulPowerDecompose>();
        public List<FB_SoulPowerDecompose> ListData
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
        public FB_SoulPowerDecompose GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_SoulPowerDecompose);
        }
        public Dictionary<int, FB_SoulPowerDecompose> GetData()
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
            if (!FB_SoulPowerDecomposeContainer.FB_SoulPowerDecomposeContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_SoulPowerDecomposeContainer.GetRootAsFB_SoulPowerDecomposeContainer(bb);
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
