using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_WarPetArrayTechniqueLevelUpProvider
    {
        private static FB_WarPetArrayTechniqueLevelUpProvider _Instance;
        public static FB_WarPetArrayTechniqueLevelUpProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_WarPetArrayTechniqueLevelUpProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/WarPetArrayTechniqueLevelUp.txt";
        protected Dictionary<int, FB_WarPetArrayTechniqueLevelUp> mData = new Dictionary<int, FB_WarPetArrayTechniqueLevelUp>();
        private List<FB_WarPetArrayTechniqueLevelUp> mListData = new List<FB_WarPetArrayTechniqueLevelUp>();
        public List<FB_WarPetArrayTechniqueLevelUp> ListData
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
        public FB_WarPetArrayTechniqueLevelUp GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_WarPetArrayTechniqueLevelUp);
        }
        public Dictionary<int, FB_WarPetArrayTechniqueLevelUp> GetData()
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
            if (!FB_WarPetArrayTechniqueLevelUpContainer.FB_WarPetArrayTechniqueLevelUpContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_WarPetArrayTechniqueLevelUpContainer.GetRootAsFB_WarPetArrayTechniqueLevelUpContainer(bb);
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
