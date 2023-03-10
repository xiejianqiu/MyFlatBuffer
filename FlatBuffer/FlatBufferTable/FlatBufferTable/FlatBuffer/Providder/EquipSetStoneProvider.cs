using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_EquipSetStoneProvider
    {
        private static FB_EquipSetStoneProvider _Instance;
        public static FB_EquipSetStoneProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_EquipSetStoneProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/EquipSetStone.txt";
        protected Dictionary<int, FB_EquipSetStone> mData = new Dictionary<int, FB_EquipSetStone>();
        private List<FB_EquipSetStone> mListData = new List<FB_EquipSetStone>();
        public List<FB_EquipSetStone> ListData
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
        public FB_EquipSetStone GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_EquipSetStone);
        }
        public Dictionary<int, FB_EquipSetStone> GetData()
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
            if (!FB_EquipSetStoneContainer.FB_EquipSetStoneContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_EquipSetStoneContainer.GetRootAsFB_EquipSetStoneContainer(bb);
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
