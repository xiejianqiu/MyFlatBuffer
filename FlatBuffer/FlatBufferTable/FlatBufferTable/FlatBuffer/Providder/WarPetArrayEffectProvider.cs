using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_WarPetArrayEffectProvider
    {
        private static FB_WarPetArrayEffectProvider _Instance;
        public static FB_WarPetArrayEffectProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_WarPetArrayEffectProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/WarPetArrayEffect.txt";
        protected Dictionary<int, FB_WarPetArrayEffect> mData = new Dictionary<int, FB_WarPetArrayEffect>();
        private List<FB_WarPetArrayEffect> mListData = new List<FB_WarPetArrayEffect>();
        public List<FB_WarPetArrayEffect> ListData
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
        public FB_WarPetArrayEffect GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_WarPetArrayEffect);
        }
        public Dictionary<int, FB_WarPetArrayEffect> GetData()
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
            if (!FB_WarPetArrayEffectContainer.FB_WarPetArrayEffectContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_WarPetArrayEffectContainer.GetRootAsFB_WarPetArrayEffectContainer(bb);
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
