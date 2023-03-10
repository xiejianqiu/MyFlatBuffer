using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_CardFlopBaseProvider
    {
        private static FB_CardFlopBaseProvider _Instance;
        public static FB_CardFlopBaseProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_CardFlopBaseProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/CardFlopBase.txt";
        protected Dictionary<int, FB_CardFlopBase> mData = new Dictionary<int, FB_CardFlopBase>();
        private List<FB_CardFlopBase> mListData = new List<FB_CardFlopBase>();
        public List<FB_CardFlopBase> ListData
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
        public FB_CardFlopBase GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_CardFlopBase);
        }
        public Dictionary<int, FB_CardFlopBase> GetData()
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
            if (!FB_CardFlopBaseContainer.FB_CardFlopBaseContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_CardFlopBaseContainer.GetRootAsFB_CardFlopBaseContainer(bb);
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
