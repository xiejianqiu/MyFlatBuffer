using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_IapGift2Provider
    {
        private static FB_IapGift2Provider _Instance;
        public static FB_IapGift2Provider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_IapGift2Provider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/IapGift2.txt";
        protected Dictionary<int, FB_IapGift2> mData = new Dictionary<int, FB_IapGift2>();
        private List<FB_IapGift2> mListData = new List<FB_IapGift2>();
        public List<FB_IapGift2> ListData
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
        public FB_IapGift2 GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_IapGift2);
        }
        public Dictionary<int, FB_IapGift2> GetData()
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
            if (!FB_IapGift2Container.FB_IapGift2ContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_IapGift2Container.GetRootAsFB_IapGift2Container(bb);
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
