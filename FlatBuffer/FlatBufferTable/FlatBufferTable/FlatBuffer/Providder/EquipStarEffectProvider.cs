using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_EquipStarEffectProvider
    {
        private static FB_EquipStarEffectProvider _Instance;
        public static FB_EquipStarEffectProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_EquipStarEffectProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Client/EquipStarEffect.txt";
        protected Dictionary<int, FB_EquipStarEffect> mData = new Dictionary<int, FB_EquipStarEffect>();
        private List<FB_EquipStarEffect> mListData = new List<FB_EquipStarEffect>();
        public List<FB_EquipStarEffect> ListData
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
        public FB_EquipStarEffect GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_EquipStarEffect);
        }
        public Dictionary<int, FB_EquipStarEffect> GetData()
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
            if (!FB_EquipStarEffectContainer.FB_EquipStarEffectContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_EquipStarEffectContainer.GetRootAsFB_EquipStarEffectContainer(bb);
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
