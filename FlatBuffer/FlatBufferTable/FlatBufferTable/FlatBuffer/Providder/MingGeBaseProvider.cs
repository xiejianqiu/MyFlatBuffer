using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_MingGeBaseProvider
    {
        private static FB_MingGeBaseProvider _Instance;
        public static FB_MingGeBaseProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_MingGeBaseProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/MingGeBase.txt";
        protected Dictionary<int, FB_MingGeBase> mData = new Dictionary<int, FB_MingGeBase>();
        private List<FB_MingGeBase> mListData = new List<FB_MingGeBase>();
        public List<FB_MingGeBase> ListData
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
        public FB_MingGeBase GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_MingGeBase);
        }
        public Dictionary<int, FB_MingGeBase> GetData()
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
            if (!FB_MingGeBaseContainer.FB_MingGeBaseContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_MingGeBaseContainer.GetRootAsFB_MingGeBaseContainer(bb);
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
