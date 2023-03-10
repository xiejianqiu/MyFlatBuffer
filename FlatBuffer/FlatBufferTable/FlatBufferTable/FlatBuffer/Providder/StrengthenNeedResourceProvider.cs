using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_StrengthenNeedResourceProvider
    {
        private static FB_StrengthenNeedResourceProvider _Instance;
        public static FB_StrengthenNeedResourceProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_StrengthenNeedResourceProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Client/StrengthenNeedResource.txt";
        protected Dictionary<int, FB_StrengthenNeedResource> mData = new Dictionary<int, FB_StrengthenNeedResource>();
        private List<FB_StrengthenNeedResource> mListData = new List<FB_StrengthenNeedResource>();
        public List<FB_StrengthenNeedResource> ListData
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
        public FB_StrengthenNeedResource GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_StrengthenNeedResource);
        }
        public Dictionary<int, FB_StrengthenNeedResource> GetData()
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
            if (!FB_StrengthenNeedResourceContainer.FB_StrengthenNeedResourceContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_StrengthenNeedResourceContainer.GetRootAsFB_StrengthenNeedResourceContainer(bb);
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
