using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_StarWishRewardShowProvider
    {
        private static FB_StarWishRewardShowProvider _Instance;
        public static FB_StarWishRewardShowProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_StarWishRewardShowProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Client/StarWishRewardShow.txt";
        protected Dictionary<int, FB_StarWishRewardShow> mData = new Dictionary<int, FB_StarWishRewardShow>();
        private List<FB_StarWishRewardShow> mListData = new List<FB_StarWishRewardShow>();
        public List<FB_StarWishRewardShow> ListData
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
        public FB_StarWishRewardShow GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_StarWishRewardShow);
        }
        public Dictionary<int, FB_StarWishRewardShow> GetData()
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
            if (!FB_StarWishRewardShowContainer.FB_StarWishRewardShowContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_StarWishRewardShowContainer.GetRootAsFB_StarWishRewardShowContainer(bb);
            for (int index = 0; index < data.ItemsLength; index++)
            {
                var item = data.GetItems(index);
                mData.Add(item.ModelTypeId, item);
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
