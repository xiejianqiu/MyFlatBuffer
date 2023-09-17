using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_PetMountProvider
    {
        private static FB_PetMountProvider _Instance;
        public static FB_PetMountProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_PetMountProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/PetMount.txt";
        protected Dictionary<int, FB_PetMount> mData = new Dictionary<int, FB_PetMount>();
        private List<FB_PetMount> mListData = new List<FB_PetMount>();
        public List<FB_PetMount> ListData
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
        public FB_PetMount GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_PetMount);
        }
        public Dictionary<int, FB_PetMount> GetData()
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
            if (!FB_PetMountContainer.FB_PetMountContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_PetMountContainer.GetRootAsFB_PetMountContainer(bb);
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
