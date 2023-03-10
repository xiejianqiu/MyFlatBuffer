using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_SoulPowerLevelUpProvider
    {
        private static FB_SoulPowerLevelUpProvider _Instance;
        public static FB_SoulPowerLevelUpProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_SoulPowerLevelUpProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/SoulPowerLevelUp.txt";
        protected Dictionary<int, FB_SoulPowerLevelUp> mData = new Dictionary<int, FB_SoulPowerLevelUp>();
        private List<FB_SoulPowerLevelUp> mListData = new List<FB_SoulPowerLevelUp>();
        public List<FB_SoulPowerLevelUp> ListData
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
        public FB_SoulPowerLevelUp GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_SoulPowerLevelUp);
        }
        public Dictionary<int, FB_SoulPowerLevelUp> GetData()
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
            if (!FB_SoulPowerLevelUpContainer.FB_SoulPowerLevelUpContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_SoulPowerLevelUpContainer.GetRootAsFB_SoulPowerLevelUpContainer(bb);
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
