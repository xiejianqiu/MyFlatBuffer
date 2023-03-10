using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_WarPetCompoundProvider
    {
        private static FB_WarPetCompoundProvider _Instance;
        public static FB_WarPetCompoundProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_WarPetCompoundProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/WarPetCompound.txt";
        protected Dictionary<int, FB_WarPetCompound> mData = new Dictionary<int, FB_WarPetCompound>();
        private List<FB_WarPetCompound> mListData = new List<FB_WarPetCompound>();
        public List<FB_WarPetCompound> ListData
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
        public FB_WarPetCompound GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_WarPetCompound);
        }
        public Dictionary<int, FB_WarPetCompound> GetData()
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
            if (!FB_WarPetCompoundContainer.FB_WarPetCompoundContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_WarPetCompoundContainer.GetRootAsFB_WarPetCompoundContainer(bb);
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
