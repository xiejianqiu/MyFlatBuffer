using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_EquipFuLingLevelUpProvider
    {
        private static FB_EquipFuLingLevelUpProvider _Instance;
        public static FB_EquipFuLingLevelUpProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_EquipFuLingLevelUpProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/EquipFuLingLevelUp.txt";
        protected Dictionary<int, FB_EquipFuLingLevelUp> mData = new Dictionary<int, FB_EquipFuLingLevelUp>();
        private List<FB_EquipFuLingLevelUp> mListData = new List<FB_EquipFuLingLevelUp>();
        public List<FB_EquipFuLingLevelUp> ListData
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
        public FB_EquipFuLingLevelUp GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_EquipFuLingLevelUp);
        }
        public Dictionary<int, FB_EquipFuLingLevelUp> GetData()
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
            if (!FB_EquipFuLingLevelUpContainer.FB_EquipFuLingLevelUpContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_EquipFuLingLevelUpContainer.GetRootAsFB_EquipFuLingLevelUpContainer(bb);
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
