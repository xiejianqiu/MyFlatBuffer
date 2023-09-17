using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_GodWeaponBaseProvider
    {
        private static FB_GodWeaponBaseProvider _Instance;
        public static FB_GodWeaponBaseProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_GodWeaponBaseProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/GodWeaponBase.txt";
        protected Dictionary<int, FB_GodWeaponBase> mData = new Dictionary<int, FB_GodWeaponBase>();
        private List<FB_GodWeaponBase> mListData = new List<FB_GodWeaponBase>();
        public List<FB_GodWeaponBase> ListData
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
        public FB_GodWeaponBase GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_GodWeaponBase);
        }
        public Dictionary<int, FB_GodWeaponBase> GetData()
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
            if (!FB_GodWeaponBaseContainer.FB_GodWeaponBaseContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_GodWeaponBaseContainer.GetRootAsFB_GodWeaponBaseContainer(bb);
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
