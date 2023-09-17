using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_WarPetStarProvider
    {
        private static FB_WarPetStarProvider _Instance;
        public static FB_WarPetStarProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_WarPetStarProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/WarPetStar.txt";
        protected Dictionary<int, FB_WarPetStar> mData = new Dictionary<int, FB_WarPetStar>();
        private List<FB_WarPetStar> mListData = new List<FB_WarPetStar>();
        public List<FB_WarPetStar> ListData
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
        public FB_WarPetStar GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_WarPetStar);
        }
        public Dictionary<int, FB_WarPetStar> GetData()
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
            if (!FB_WarPetStarContainer.FB_WarPetStarContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_WarPetStarContainer.GetRootAsFB_WarPetStarContainer(bb);
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
