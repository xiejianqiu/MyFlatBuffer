using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_LingBaoBaseProvider
    {
        private static FB_LingBaoBaseProvider _Instance;
        public static FB_LingBaoBaseProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_LingBaoBaseProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/LingBaoBase.txt";
        protected Dictionary<int, FB_LingBaoBase> mData = new Dictionary<int, FB_LingBaoBase>();
        private List<FB_LingBaoBase> mListData = new List<FB_LingBaoBase>();
        public List<FB_LingBaoBase> ListData
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
        public FB_LingBaoBase GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_LingBaoBase);
        }
        public Dictionary<int, FB_LingBaoBase> GetData()
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
            if (!FB_LingBaoBaseContainer.FB_LingBaoBaseContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_LingBaoBaseContainer.GetRootAsFB_LingBaoBaseContainer(bb);
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
