using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_ShenShouEquipBaseProvider
    {
        private static FB_ShenShouEquipBaseProvider _Instance;
        public static FB_ShenShouEquipBaseProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_ShenShouEquipBaseProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/ShenShouEquipBase.txt";
        protected Dictionary<int, FB_ShenShouEquipBase> mData = new Dictionary<int, FB_ShenShouEquipBase>();
        private List<FB_ShenShouEquipBase> mListData = new List<FB_ShenShouEquipBase>();
        public List<FB_ShenShouEquipBase> ListData
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
        public FB_ShenShouEquipBase GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_ShenShouEquipBase);
        }
        public Dictionary<int, FB_ShenShouEquipBase> GetData()
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
            if (!FB_ShenShouEquipBaseContainer.FB_ShenShouEquipBaseContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_ShenShouEquipBaseContainer.GetRootAsFB_ShenShouEquipBaseContainer(bb);
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
