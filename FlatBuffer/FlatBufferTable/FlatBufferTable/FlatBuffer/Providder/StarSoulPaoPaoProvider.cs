using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_StarSoulPaoPaoProvider
    {
        private static FB_StarSoulPaoPaoProvider _Instance;
        public static FB_StarSoulPaoPaoProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_StarSoulPaoPaoProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Client/StarSoulPaoPao.txt";
        protected Dictionary<int, FB_StarSoulPaoPao> mData = new Dictionary<int, FB_StarSoulPaoPao>();
        private List<FB_StarSoulPaoPao> mListData = new List<FB_StarSoulPaoPao>();
        public List<FB_StarSoulPaoPao> ListData
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
        public FB_StarSoulPaoPao GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_StarSoulPaoPao);
        }
        public Dictionary<int, FB_StarSoulPaoPao> GetData()
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
            if (!FB_StarSoulPaoPaoContainer.FB_StarSoulPaoPaoContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_StarSoulPaoPaoContainer.GetRootAsFB_StarSoulPaoPaoContainer(bb);
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
