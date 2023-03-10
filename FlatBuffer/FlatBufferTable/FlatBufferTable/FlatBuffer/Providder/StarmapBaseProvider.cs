using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_StarmapBaseProvider
    {
        private static FB_StarmapBaseProvider _Instance;
        public static FB_StarmapBaseProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_StarmapBaseProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/StarmapBase.txt";
        protected Dictionary<int, FB_StarmapBase> mData = new Dictionary<int, FB_StarmapBase>();
        private List<FB_StarmapBase> mListData = new List<FB_StarmapBase>();
        public List<FB_StarmapBase> ListData
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
        public FB_StarmapBase GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_StarmapBase);
        }
        public Dictionary<int, FB_StarmapBase> GetData()
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
            if (!FB_StarmapBaseContainer.FB_StarmapBaseContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_StarmapBaseContainer.GetRootAsFB_StarmapBaseContainer(bb);
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
