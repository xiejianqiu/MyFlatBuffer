using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_StrengthenSubClassProvider
    {
        private static FB_StrengthenSubClassProvider _Instance;
        public static FB_StrengthenSubClassProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_StrengthenSubClassProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/StrengthenSubClass.txt";
        protected Dictionary<int, FB_StrengthenSubClass> mData = new Dictionary<int, FB_StrengthenSubClass>();
        private List<FB_StrengthenSubClass> mListData = new List<FB_StrengthenSubClass>();
        public List<FB_StrengthenSubClass> ListData
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
        public FB_StrengthenSubClass GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_StrengthenSubClass);
        }
        public Dictionary<int, FB_StrengthenSubClass> GetData()
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
            if (!FB_StrengthenSubClassContainer.FB_StrengthenSubClassContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_StrengthenSubClassContainer.GetRootAsFB_StrengthenSubClassContainer(bb);
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
