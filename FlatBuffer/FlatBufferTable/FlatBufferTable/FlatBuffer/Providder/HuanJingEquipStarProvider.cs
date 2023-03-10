using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_HuanJingEquipStarProvider
    {
        private static FB_HuanJingEquipStarProvider _Instance;
        public static FB_HuanJingEquipStarProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_HuanJingEquipStarProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/HuanJingEquipStar.txt";
        protected Dictionary<int, FB_HuanJingEquipStar> mData = new Dictionary<int, FB_HuanJingEquipStar>();
        private List<FB_HuanJingEquipStar> mListData = new List<FB_HuanJingEquipStar>();
        public List<FB_HuanJingEquipStar> ListData
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
        public FB_HuanJingEquipStar GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_HuanJingEquipStar);
        }
        public Dictionary<int, FB_HuanJingEquipStar> GetData()
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
            if (!FB_HuanJingEquipStarContainer.FB_HuanJingEquipStarContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_HuanJingEquipStarContainer.GetRootAsFB_HuanJingEquipStarContainer(bb);
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
