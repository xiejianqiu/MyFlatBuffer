using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_StrengthenBaseProvider
    {
        private static FB_StrengthenBaseProvider _Instance;
        public static FB_StrengthenBaseProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_StrengthenBaseProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/StrengthenBase.txt";
        protected Dictionary<int, FB_StrengthenBase> mData = new Dictionary<int, FB_StrengthenBase>();
        private List<FB_StrengthenBase> mListData = new List<FB_StrengthenBase>();
        public List<FB_StrengthenBase> ListData
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
        public FB_StrengthenBase GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_StrengthenBase);
        }
        public Dictionary<int, FB_StrengthenBase> GetData()
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
            if (!FB_StrengthenBaseContainer.FB_StrengthenBaseContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_StrengthenBaseContainer.GetRootAsFB_StrengthenBaseContainer(bb);
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
