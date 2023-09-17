using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_ShenWangZhanJiaPaintingPayProvider
    {
        private static FB_ShenWangZhanJiaPaintingPayProvider _Instance;
        public static FB_ShenWangZhanJiaPaintingPayProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_ShenWangZhanJiaPaintingPayProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/ShenWangZhanJiaPaintingPay.txt";
        protected Dictionary<int, FB_ShenWangZhanJiaPaintingPay> mData = new Dictionary<int, FB_ShenWangZhanJiaPaintingPay>();
        private List<FB_ShenWangZhanJiaPaintingPay> mListData = new List<FB_ShenWangZhanJiaPaintingPay>();
        public List<FB_ShenWangZhanJiaPaintingPay> ListData
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
        public FB_ShenWangZhanJiaPaintingPay GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_ShenWangZhanJiaPaintingPay);
        }
        public Dictionary<int, FB_ShenWangZhanJiaPaintingPay> GetData()
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
            if (!FB_ShenWangZhanJiaPaintingPayContainer.FB_ShenWangZhanJiaPaintingPayContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_ShenWangZhanJiaPaintingPayContainer.GetRootAsFB_ShenWangZhanJiaPaintingPayContainer(bb);
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
