using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_EquipFusionBaseProvider
    {
        private static FB_EquipFusionBaseProvider _Instance;
        public static FB_EquipFusionBaseProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_EquipFusionBaseProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/EquipFusionBase.txt";
        protected Dictionary<int, FB_EquipFusionBase> mData = new Dictionary<int, FB_EquipFusionBase>();
        private List<FB_EquipFusionBase> mListData = new List<FB_EquipFusionBase>();
        public List<FB_EquipFusionBase> ListData
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
        public FB_EquipFusionBase GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_EquipFusionBase);
        }
        public Dictionary<int, FB_EquipFusionBase> GetData()
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
            if (!FB_EquipFusionBaseContainer.FB_EquipFusionBaseContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_EquipFusionBaseContainer.GetRootAsFB_EquipFusionBaseContainer(bb);
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
