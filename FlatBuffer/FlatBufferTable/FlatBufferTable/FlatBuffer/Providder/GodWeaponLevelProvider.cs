using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_GodWeaponLevelProvider
    {
        private static FB_GodWeaponLevelProvider _Instance;
        public static FB_GodWeaponLevelProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_GodWeaponLevelProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/GodWeaponLevel.txt";
        protected Dictionary<int, FB_GodWeaponLevel> mData = new Dictionary<int, FB_GodWeaponLevel>();
        private List<FB_GodWeaponLevel> mListData = new List<FB_GodWeaponLevel>();
        public List<FB_GodWeaponLevel> ListData
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
        public FB_GodWeaponLevel GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_GodWeaponLevel);
        }
        public Dictionary<int, FB_GodWeaponLevel> GetData()
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
            if (!FB_GodWeaponLevelContainer.FB_GodWeaponLevelContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_GodWeaponLevelContainer.GetRootAsFB_GodWeaponLevelContainer(bb);
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
