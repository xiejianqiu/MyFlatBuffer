using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_HunGeBaseProvider
    {
        private static FB_HunGeBaseProvider _Instance;
        public static FB_HunGeBaseProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_HunGeBaseProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/HunGeBase.txt";
        protected Dictionary<int, FB_HunGeBase> mData = new Dictionary<int, FB_HunGeBase>();
        private List<FB_HunGeBase> mListData = new List<FB_HunGeBase>();
        public List<FB_HunGeBase> ListData
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
        public FB_HunGeBase GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_HunGeBase);
        }
        public Dictionary<int, FB_HunGeBase> GetData()
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
            if (!FB_HunGeBaseContainer.FB_HunGeBaseContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_HunGeBaseContainer.GetRootAsFB_HunGeBaseContainer(bb);
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
