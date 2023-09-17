using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_CombatPetSceneProvider
    {
        private static FB_CombatPetSceneProvider _Instance;
        public static FB_CombatPetSceneProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_CombatPetSceneProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Client/CombatPetScene.txt";
        protected Dictionary<int, FB_CombatPetScene> mData = new Dictionary<int, FB_CombatPetScene>();
        private List<FB_CombatPetScene> mListData = new List<FB_CombatPetScene>();
        public List<FB_CombatPetScene> ListData
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
        public FB_CombatPetScene GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_CombatPetScene);
        }
        public Dictionary<int, FB_CombatPetScene> GetData()
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
            if (!FB_CombatPetSceneContainer.FB_CombatPetSceneContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_CombatPetSceneContainer.GetRootAsFB_CombatPetSceneContainer(bb);
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
