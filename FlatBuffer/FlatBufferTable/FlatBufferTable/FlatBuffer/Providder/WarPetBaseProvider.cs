using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_WarPetBaseProvider
    {
        private static FB_WarPetBaseProvider _Instance;
        public static FB_WarPetBaseProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_WarPetBaseProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/WarPetBase.txt";
        protected Dictionary<int, FB_WarPetBase> mData = new Dictionary<int, FB_WarPetBase>();
        private List<FB_WarPetBase> mListData = new List<FB_WarPetBase>();
        public List<FB_WarPetBase> ListData
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
        public FB_WarPetBase GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_WarPetBase);
        }
        public Dictionary<int, FB_WarPetBase> GetData()
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
            if (!FB_WarPetBaseContainer.FB_WarPetBaseContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_WarPetBaseContainer.GetRootAsFB_WarPetBaseContainer(bb);
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
