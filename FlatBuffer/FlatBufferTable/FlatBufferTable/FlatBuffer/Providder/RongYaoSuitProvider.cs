using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_RongYaoSuitProvider
    {
        private static FB_RongYaoSuitProvider _Instance;
        public static FB_RongYaoSuitProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_RongYaoSuitProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/RongYaoSuit.txt";
        protected Dictionary<int, FB_RongYaoSuit> mData = new Dictionary<int, FB_RongYaoSuit>();
        private List<FB_RongYaoSuit> mListData = new List<FB_RongYaoSuit>();
        public List<FB_RongYaoSuit> ListData
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
        public FB_RongYaoSuit GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_RongYaoSuit);
        }
        public Dictionary<int, FB_RongYaoSuit> GetData()
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
            if (!FB_RongYaoSuitContainer.FB_RongYaoSuitContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_RongYaoSuitContainer.GetRootAsFB_RongYaoSuitContainer(bb);
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
