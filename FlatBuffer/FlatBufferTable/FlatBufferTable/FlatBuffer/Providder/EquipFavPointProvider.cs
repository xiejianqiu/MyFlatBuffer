using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_EquipFavPointProvider
    {
        private static FB_EquipFavPointProvider _Instance;
        public static FB_EquipFavPointProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_EquipFavPointProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/EquipFavPoint.txt";
        protected Dictionary<int, FB_EquipFavPoint> mData = new Dictionary<int, FB_EquipFavPoint>();
        private List<FB_EquipFavPoint> mListData = new List<FB_EquipFavPoint>();
        public List<FB_EquipFavPoint> ListData
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
        public FB_EquipFavPoint GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_EquipFavPoint);
        }
        public Dictionary<int, FB_EquipFavPoint> GetData()
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
            if (!FB_EquipFavPointContainer.FB_EquipFavPointContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_EquipFavPointContainer.GetRootAsFB_EquipFavPointContainer(bb);
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
