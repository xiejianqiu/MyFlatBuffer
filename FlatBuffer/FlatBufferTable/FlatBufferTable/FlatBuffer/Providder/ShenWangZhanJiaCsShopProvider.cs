using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_ShenWangZhanJiaCsShopProvider
    {
        private static FB_ShenWangZhanJiaCsShopProvider _Instance;
        public static FB_ShenWangZhanJiaCsShopProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_ShenWangZhanJiaCsShopProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/ShenWangZhanJiaCsShop.txt";
        protected Dictionary<int, FB_ShenWangZhanJiaCsShop> mData = new Dictionary<int, FB_ShenWangZhanJiaCsShop>();
        private List<FB_ShenWangZhanJiaCsShop> mListData = new List<FB_ShenWangZhanJiaCsShop>();
        public List<FB_ShenWangZhanJiaCsShop> ListData
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
        public FB_ShenWangZhanJiaCsShop GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_ShenWangZhanJiaCsShop);
        }
        public Dictionary<int, FB_ShenWangZhanJiaCsShop> GetData()
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
            if (!FB_ShenWangZhanJiaCsShopContainer.FB_ShenWangZhanJiaCsShopContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_ShenWangZhanJiaCsShopContainer.GetRootAsFB_ShenWangZhanJiaCsShopContainer(bb);
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
