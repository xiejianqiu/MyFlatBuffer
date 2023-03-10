using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_EquipExhibitionProvider
    {
        private static FB_EquipExhibitionProvider _Instance;
        public static FB_EquipExhibitionProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_EquipExhibitionProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/EquipExhibition.txt";
        protected Dictionary<int, FB_EquipExhibition> mData = new Dictionary<int, FB_EquipExhibition>();
        private List<FB_EquipExhibition> mListData = new List<FB_EquipExhibition>();
        public List<FB_EquipExhibition> ListData
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
        public FB_EquipExhibition GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_EquipExhibition);
        }
        public Dictionary<int, FB_EquipExhibition> GetData()
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
            if (!FB_EquipExhibitionContainer.FB_EquipExhibitionContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_EquipExhibitionContainer.GetRootAsFB_EquipExhibitionContainer(bb);
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
