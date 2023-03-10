using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_ShenShouEquipLevelUpProvider
    {
        private static FB_ShenShouEquipLevelUpProvider _Instance;
        public static FB_ShenShouEquipLevelUpProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_ShenShouEquipLevelUpProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/ShenShouEquipLevelUp.txt";
        protected Dictionary<int, FB_ShenShouEquipLevelUp> mData = new Dictionary<int, FB_ShenShouEquipLevelUp>();
        private List<FB_ShenShouEquipLevelUp> mListData = new List<FB_ShenShouEquipLevelUp>();
        public List<FB_ShenShouEquipLevelUp> ListData
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
        public FB_ShenShouEquipLevelUp GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_ShenShouEquipLevelUp);
        }
        public Dictionary<int, FB_ShenShouEquipLevelUp> GetData()
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
            if (!FB_ShenShouEquipLevelUpContainer.FB_ShenShouEquipLevelUpContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_ShenShouEquipLevelUpContainer.GetRootAsFB_ShenShouEquipLevelUpContainer(bb);
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
