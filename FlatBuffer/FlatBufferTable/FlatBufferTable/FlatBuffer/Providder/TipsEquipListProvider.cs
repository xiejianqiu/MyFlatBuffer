using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_TipsEquipListProvider
    {
        private static FB_TipsEquipListProvider _Instance;
        public static FB_TipsEquipListProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_TipsEquipListProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Client/TipsEquipList.txt";
        protected Dictionary<int, FB_TipsEquipList> mData = new Dictionary<int, FB_TipsEquipList>();
        private List<FB_TipsEquipList> mListData = new List<FB_TipsEquipList>();
        public List<FB_TipsEquipList> ListData
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
        public FB_TipsEquipList GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_TipsEquipList);
        }
        public Dictionary<int, FB_TipsEquipList> GetData()
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
            if (!FB_TipsEquipListContainer.FB_TipsEquipListContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_TipsEquipListContainer.GetRootAsFB_TipsEquipListContainer(bb);
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
