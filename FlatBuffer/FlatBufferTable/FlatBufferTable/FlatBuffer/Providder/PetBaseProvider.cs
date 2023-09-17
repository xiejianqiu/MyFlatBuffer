using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_PetBaseProvider
    {
        private static FB_PetBaseProvider _Instance;
        public static FB_PetBaseProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_PetBaseProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/PetBase.txt";
        protected Dictionary<int, FB_PetBase> mData = new Dictionary<int, FB_PetBase>();
        private List<FB_PetBase> mListData = new List<FB_PetBase>();
        public List<FB_PetBase> ListData
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
        public FB_PetBase GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_PetBase);
        }
        public Dictionary<int, FB_PetBase> GetData()
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
            if (!FB_PetBaseContainer.FB_PetBaseContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_PetBaseContainer.GetRootAsFB_PetBaseContainer(bb);
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
