using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_EquipSourceProvider
    {
        private static FB_EquipSourceProvider _Instance;
        public static FB_EquipSourceProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_EquipSourceProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/EquipSource.txt";
        protected Dictionary<int, FB_EquipSource> mData = new Dictionary<int, FB_EquipSource>();
        private List<FB_EquipSource> mListData = new List<FB_EquipSource>();
        public List<FB_EquipSource> ListData
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
        public FB_EquipSource GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_EquipSource);
        }
        public Dictionary<int, FB_EquipSource> GetData()
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
            if (!FB_EquipSourceContainer.FB_EquipSourceContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_EquipSourceContainer.GetRootAsFB_EquipSourceContainer(bb);
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
