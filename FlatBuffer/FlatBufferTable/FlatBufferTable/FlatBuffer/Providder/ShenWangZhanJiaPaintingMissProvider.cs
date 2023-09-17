using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_ShenWangZhanJiaPaintingMissProvider
    {
        private static FB_ShenWangZhanJiaPaintingMissProvider _Instance;
        public static FB_ShenWangZhanJiaPaintingMissProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_ShenWangZhanJiaPaintingMissProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/ShenWangZhanJiaPaintingMiss.txt";
        protected Dictionary<int, FB_ShenWangZhanJiaPaintingMiss> mData = new Dictionary<int, FB_ShenWangZhanJiaPaintingMiss>();
        private List<FB_ShenWangZhanJiaPaintingMiss> mListData = new List<FB_ShenWangZhanJiaPaintingMiss>();
        public List<FB_ShenWangZhanJiaPaintingMiss> ListData
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
        public FB_ShenWangZhanJiaPaintingMiss GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_ShenWangZhanJiaPaintingMiss);
        }
        public Dictionary<int, FB_ShenWangZhanJiaPaintingMiss> GetData()
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
            if (!FB_ShenWangZhanJiaPaintingMissContainer.FB_ShenWangZhanJiaPaintingMissContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_ShenWangZhanJiaPaintingMissContainer.GetRootAsFB_ShenWangZhanJiaPaintingMissContainer(bb);
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
