using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_CardBaseProvider
    {
        private static FB_CardBaseProvider _Instance;
        public static FB_CardBaseProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_CardBaseProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/CardBase.txt";
        protected Dictionary<int, FB_CardBase> mData = new Dictionary<int, FB_CardBase>();
        private List<FB_CardBase> mListData = new List<FB_CardBase>();
        public List<FB_CardBase> ListData
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
        public FB_CardBase GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_CardBase);
        }
        public Dictionary<int, FB_CardBase> GetData()
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
            if (!FB_CardBaseContainer.FB_CardBaseContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_CardBaseContainer.GetRootAsFB_CardBaseContainer(bb);
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
