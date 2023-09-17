using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_CombatPetRewardProvider
    {
        private static FB_CombatPetRewardProvider _Instance;
        public static FB_CombatPetRewardProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_CombatPetRewardProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/CombatPetReward.txt";
        protected Dictionary<int, FB_CombatPetReward> mData = new Dictionary<int, FB_CombatPetReward>();
        private List<FB_CombatPetReward> mListData = new List<FB_CombatPetReward>();
        public List<FB_CombatPetReward> ListData
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
        public FB_CombatPetReward GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_CombatPetReward);
        }
        public Dictionary<int, FB_CombatPetReward> GetData()
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
            if (!FB_CombatPetRewardContainer.FB_CombatPetRewardContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_CombatPetRewardContainer.GetRootAsFB_CombatPetRewardContainer(bb);
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
