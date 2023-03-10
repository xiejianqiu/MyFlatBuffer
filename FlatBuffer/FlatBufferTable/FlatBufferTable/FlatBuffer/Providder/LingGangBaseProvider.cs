using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_LingGangBaseProvider
    {
        private static FB_LingGangBaseProvider _Instance;
        public static FB_LingGangBaseProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_LingGangBaseProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/LingGangBase.txt";
        protected Dictionary<int, FB_LingGangBase> mData = new Dictionary<int, FB_LingGangBase>();
        private List<FB_LingGangBase> mListData = new List<FB_LingGangBase>();
        public List<FB_LingGangBase> ListData
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
        public FB_LingGangBase GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_LingGangBase);
        }
        public Dictionary<int, FB_LingGangBase> GetData()
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
            if (!FB_LingGangBaseContainer.FB_LingGangBaseContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_LingGangBaseContainer.GetRootAsFB_LingGangBaseContainer(bb);
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
