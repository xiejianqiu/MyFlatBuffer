using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_PackageUnlockProvider
    {
        private static FB_PackageUnlockProvider _Instance;
        public static FB_PackageUnlockProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_PackageUnlockProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/PackageUnlock.txt";
        protected Dictionary<int, FB_PackageUnlock> mData = new Dictionary<int, FB_PackageUnlock>();
        private List<FB_PackageUnlock> mListData = new List<FB_PackageUnlock>();
        public List<FB_PackageUnlock> ListData
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
        public FB_PackageUnlock GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_PackageUnlock);
        }
        public Dictionary<int, FB_PackageUnlock> GetData()
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
            if (!FB_PackageUnlockContainer.FB_PackageUnlockContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_PackageUnlockContainer.GetRootAsFB_PackageUnlockContainer(bb);
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
