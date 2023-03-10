using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_WarPetModelProvider
    {
        private static FB_WarPetModelProvider _Instance;
        public static FB_WarPetModelProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_WarPetModelProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Client/WarPetModel.txt";
        protected Dictionary<int, FB_WarPetModel> mData = new Dictionary<int, FB_WarPetModel>();
        private List<FB_WarPetModel> mListData = new List<FB_WarPetModel>();
        public List<FB_WarPetModel> ListData
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
        public FB_WarPetModel GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_WarPetModel);
        }
        public Dictionary<int, FB_WarPetModel> GetData()
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
            if (!FB_WarPetModelContainer.FB_WarPetModelContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_WarPetModelContainer.GetRootAsFB_WarPetModelContainer(bb);
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
