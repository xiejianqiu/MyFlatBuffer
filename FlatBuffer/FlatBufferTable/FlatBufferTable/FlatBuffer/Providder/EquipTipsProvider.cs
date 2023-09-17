using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_EquipTipsProvider
    {
        private static FB_EquipTipsProvider _Instance;
        public static FB_EquipTipsProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_EquipTipsProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Client/EquipTips.txt";
        protected Dictionary<int, FB_EquipTips> mData = new Dictionary<int, FB_EquipTips>();
        private List<FB_EquipTips> mListData = new List<FB_EquipTips>();
        public List<FB_EquipTips> ListData
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
        public FB_EquipTips GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_EquipTips);
        }
        public Dictionary<int, FB_EquipTips> GetData()
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
            if (!FB_EquipTipsContainer.FB_EquipTipsContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_EquipTipsContainer.GetRootAsFB_EquipTipsContainer(bb);
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
