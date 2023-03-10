using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_HuanJingEquipProvider
    {
        private static FB_HuanJingEquipProvider _Instance;
        public static FB_HuanJingEquipProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_HuanJingEquipProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/HuanJingEquip.txt";
        protected Dictionary<int, FB_HuanJingEquip> mData = new Dictionary<int, FB_HuanJingEquip>();
        private List<FB_HuanJingEquip> mListData = new List<FB_HuanJingEquip>();
        public List<FB_HuanJingEquip> ListData
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
        public FB_HuanJingEquip GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_HuanJingEquip);
        }
        public Dictionary<int, FB_HuanJingEquip> GetData()
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
            if (!FB_HuanJingEquipContainer.FB_HuanJingEquipContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_HuanJingEquipContainer.GetRootAsFB_HuanJingEquipContainer(bb);
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
