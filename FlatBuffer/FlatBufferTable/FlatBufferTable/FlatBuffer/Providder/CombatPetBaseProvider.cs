using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_CombatPetBaseProvider
    {
        private static FB_CombatPetBaseProvider _Instance;
        public static FB_CombatPetBaseProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_CombatPetBaseProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/CombatPetBase.txt";
        protected Dictionary<int, FB_CombatPetBase> mData = new Dictionary<int, FB_CombatPetBase>();
        private List<FB_CombatPetBase> mListData = new List<FB_CombatPetBase>();
        public List<FB_CombatPetBase> ListData
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
        public FB_CombatPetBase GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_CombatPetBase);
        }
        public Dictionary<int, FB_CombatPetBase> GetData()
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
            if (!FB_CombatPetBaseContainer.FB_CombatPetBaseContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_CombatPetBaseContainer.GetRootAsFB_CombatPetBaseContainer(bb);
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
