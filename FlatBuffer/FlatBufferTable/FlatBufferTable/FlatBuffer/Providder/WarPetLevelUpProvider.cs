using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_WarPetLevelUpProvider
    {
        private static FB_WarPetLevelUpProvider _Instance;
        public static FB_WarPetLevelUpProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_WarPetLevelUpProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/WarPetLevelUp.txt";
        protected Dictionary<int, FB_WarPetLevelUp> mData = new Dictionary<int, FB_WarPetLevelUp>();
        private List<FB_WarPetLevelUp> mListData = new List<FB_WarPetLevelUp>();
        public List<FB_WarPetLevelUp> ListData
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
        public FB_WarPetLevelUp GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_WarPetLevelUp);
        }
        public Dictionary<int, FB_WarPetLevelUp> GetData()
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
            if (!FB_WarPetLevelUpContainer.FB_WarPetLevelUpContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_WarPetLevelUpContainer.GetRootAsFB_WarPetLevelUpContainer(bb);
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
