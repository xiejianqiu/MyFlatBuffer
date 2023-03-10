using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_EquipCompoundTypeShenZhuangProvider
    {
        private static FB_EquipCompoundTypeShenZhuangProvider _Instance;
        public static FB_EquipCompoundTypeShenZhuangProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_EquipCompoundTypeShenZhuangProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/EquipCompoundTypeShenZhuang.txt";
        protected Dictionary<int, FB_EquipCompoundTypeShenZhuang> mData = new Dictionary<int, FB_EquipCompoundTypeShenZhuang>();
        private List<FB_EquipCompoundTypeShenZhuang> mListData = new List<FB_EquipCompoundTypeShenZhuang>();
        public List<FB_EquipCompoundTypeShenZhuang> ListData
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
        public FB_EquipCompoundTypeShenZhuang GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_EquipCompoundTypeShenZhuang);
        }
        public Dictionary<int, FB_EquipCompoundTypeShenZhuang> GetData()
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
            if (!FB_EquipCompoundTypeShenZhuangContainer.FB_EquipCompoundTypeShenZhuangContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_EquipCompoundTypeShenZhuangContainer.GetRootAsFB_EquipCompoundTypeShenZhuangContainer(bb);
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
