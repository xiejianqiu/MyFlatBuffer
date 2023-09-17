using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_EquipAttrValueProvider
    {
        private static FB_EquipAttrValueProvider _Instance;
        public static FB_EquipAttrValueProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_EquipAttrValueProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/EquipAttrValue.txt";
        protected Dictionary<int, FB_EquipAttrValue> mData = new Dictionary<int, FB_EquipAttrValue>();
        private List<FB_EquipAttrValue> mListData = new List<FB_EquipAttrValue>();
        public List<FB_EquipAttrValue> ListData
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
        public FB_EquipAttrValue GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_EquipAttrValue);
        }
        public Dictionary<int, FB_EquipAttrValue> GetData()
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
            if (!FB_EquipAttrValueContainer.FB_EquipAttrValueContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_EquipAttrValueContainer.GetRootAsFB_EquipAttrValueContainer(bb);
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
