using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_StarSoulUnitBaseProvider
    {
        private static FB_StarSoulUnitBaseProvider _Instance;
        public static FB_StarSoulUnitBaseProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_StarSoulUnitBaseProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/StarSoulUnitBase.txt";
        protected Dictionary<int, FB_StarSoulUnitBase> mData = new Dictionary<int, FB_StarSoulUnitBase>();
        private List<FB_StarSoulUnitBase> mListData = new List<FB_StarSoulUnitBase>();
        public List<FB_StarSoulUnitBase> ListData
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
        public FB_StarSoulUnitBase GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_StarSoulUnitBase);
        }
        public Dictionary<int, FB_StarSoulUnitBase> GetData()
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
            if (!FB_StarSoulUnitBaseContainer.FB_StarSoulUnitBaseContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_StarSoulUnitBaseContainer.GetRootAsFB_StarSoulUnitBaseContainer(bb);
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
