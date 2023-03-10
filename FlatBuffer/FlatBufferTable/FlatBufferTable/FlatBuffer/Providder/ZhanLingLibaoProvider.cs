using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_ZhanLingLibaoProvider
    {
        private static FB_ZhanLingLibaoProvider _Instance;
        public static FB_ZhanLingLibaoProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_ZhanLingLibaoProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/ZhanLingLibao.txt";
        protected Dictionary<int, FB_ZhanLingLibao> mData = new Dictionary<int, FB_ZhanLingLibao>();
        private List<FB_ZhanLingLibao> mListData = new List<FB_ZhanLingLibao>();
        public List<FB_ZhanLingLibao> ListData
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
        public FB_ZhanLingLibao GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_ZhanLingLibao);
        }
        public Dictionary<int, FB_ZhanLingLibao> GetData()
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
            if (!FB_ZhanLingLibaoContainer.FB_ZhanLingLibaoContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_ZhanLingLibaoContainer.GetRootAsFB_ZhanLingLibaoContainer(bb);
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
