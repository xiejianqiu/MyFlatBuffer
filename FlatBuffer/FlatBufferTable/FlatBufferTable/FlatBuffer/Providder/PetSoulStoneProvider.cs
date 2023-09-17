using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_PetSoulStoneProvider
    {
        private static FB_PetSoulStoneProvider _Instance;
        public static FB_PetSoulStoneProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_PetSoulStoneProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/PetSoulStone.txt";
        protected Dictionary<int, FB_PetSoulStone> mData = new Dictionary<int, FB_PetSoulStone>();
        private List<FB_PetSoulStone> mListData = new List<FB_PetSoulStone>();
        public List<FB_PetSoulStone> ListData
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
        public FB_PetSoulStone GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_PetSoulStone);
        }
        public Dictionary<int, FB_PetSoulStone> GetData()
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
            if (!FB_PetSoulStoneContainer.FB_PetSoulStoneContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_PetSoulStoneContainer.GetRootAsFB_PetSoulStoneContainer(bb);
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
