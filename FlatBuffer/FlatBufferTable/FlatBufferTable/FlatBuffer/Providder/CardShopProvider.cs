using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_CardShopProvider
    {
        private static FB_CardShopProvider _Instance;
        public static FB_CardShopProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_CardShopProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/CardShop.txt";
        protected Dictionary<int, FB_CardShop> mData = new Dictionary<int, FB_CardShop>();
        private List<FB_CardShop> mListData = new List<FB_CardShop>();
        public List<FB_CardShop> ListData
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
        public FB_CardShop GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_CardShop);
        }
        public Dictionary<int, FB_CardShop> GetData()
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
            if (!FB_CardShopContainer.FB_CardShopContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_CardShopContainer.GetRootAsFB_CardShopContainer(bb);
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
