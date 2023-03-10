using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_WarPetItemDecomposeProvider
    {
        private static FB_WarPetItemDecomposeProvider _Instance;
        public static FB_WarPetItemDecomposeProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_WarPetItemDecomposeProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/WarPetItemDecompose.txt";
        protected Dictionary<int, FB_WarPetItemDecompose> mData = new Dictionary<int, FB_WarPetItemDecompose>();
        private List<FB_WarPetItemDecompose> mListData = new List<FB_WarPetItemDecompose>();
        public List<FB_WarPetItemDecompose> ListData
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
        public FB_WarPetItemDecompose GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_WarPetItemDecompose);
        }
        public Dictionary<int, FB_WarPetItemDecompose> GetData()
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
            if (!FB_WarPetItemDecomposeContainer.FB_WarPetItemDecomposeContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_WarPetItemDecomposeContainer.GetRootAsFB_WarPetItemDecomposeContainer(bb);
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
