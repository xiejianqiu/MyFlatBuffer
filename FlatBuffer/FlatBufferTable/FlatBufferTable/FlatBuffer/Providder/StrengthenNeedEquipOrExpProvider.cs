using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_StrengthenNeedEquipOrExpProvider
    {
        private static FB_StrengthenNeedEquipOrExpProvider _Instance;
        public static FB_StrengthenNeedEquipOrExpProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_StrengthenNeedEquipOrExpProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Client/StrengthenNeedEquipOrExp.txt";
        protected Dictionary<int, FB_StrengthenNeedEquipOrExp> mData = new Dictionary<int, FB_StrengthenNeedEquipOrExp>();
        private List<FB_StrengthenNeedEquipOrExp> mListData = new List<FB_StrengthenNeedEquipOrExp>();
        public List<FB_StrengthenNeedEquipOrExp> ListData
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
        public FB_StrengthenNeedEquipOrExp GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_StrengthenNeedEquipOrExp);
        }
        public Dictionary<int, FB_StrengthenNeedEquipOrExp> GetData()
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
            if (!FB_StrengthenNeedEquipOrExpContainer.FB_StrengthenNeedEquipOrExpContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_StrengthenNeedEquipOrExpContainer.GetRootAsFB_StrengthenNeedEquipOrExpContainer(bb);
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
