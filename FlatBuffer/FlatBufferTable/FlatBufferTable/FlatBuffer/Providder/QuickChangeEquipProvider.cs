using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_QuickChangeEquipProvider
    {
        private static FB_QuickChangeEquipProvider _Instance;
        public static FB_QuickChangeEquipProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_QuickChangeEquipProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/QuickChangeEquip.txt";
        protected Dictionary<int, FB_QuickChangeEquip> mData = new Dictionary<int, FB_QuickChangeEquip>();
        private List<FB_QuickChangeEquip> mListData = new List<FB_QuickChangeEquip>();
        public List<FB_QuickChangeEquip> ListData
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
        public FB_QuickChangeEquip GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_QuickChangeEquip);
        }
        public Dictionary<int, FB_QuickChangeEquip> GetData()
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
            if (!FB_QuickChangeEquipContainer.FB_QuickChangeEquipContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_QuickChangeEquipContainer.GetRootAsFB_QuickChangeEquipContainer(bb);
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
