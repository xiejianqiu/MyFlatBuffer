using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_WarPetRandomStarProvider
    {
        private static FB_WarPetRandomStarProvider _Instance;
        public static FB_WarPetRandomStarProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_WarPetRandomStarProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/WarPetRandomStar.txt";
        protected Dictionary<int, FB_WarPetRandomStar> mData = new Dictionary<int, FB_WarPetRandomStar>();
        private List<FB_WarPetRandomStar> mListData = new List<FB_WarPetRandomStar>();
        public List<FB_WarPetRandomStar> ListData
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
        public FB_WarPetRandomStar GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_WarPetRandomStar);
        }
        public Dictionary<int, FB_WarPetRandomStar> GetData()
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
            if (!FB_WarPetRandomStarContainer.FB_WarPetRandomStarContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_WarPetRandomStarContainer.GetRootAsFB_WarPetRandomStarContainer(bb);
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
