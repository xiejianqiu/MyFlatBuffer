using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_XingHunUnitBaseProvider
    {
        private static FB_XingHunUnitBaseProvider _Instance;
        public static FB_XingHunUnitBaseProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_XingHunUnitBaseProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/XingHunUnitBase.txt";
        protected Dictionary<int, FB_XingHunUnitBase> mData = new Dictionary<int, FB_XingHunUnitBase>();
        private List<FB_XingHunUnitBase> mListData = new List<FB_XingHunUnitBase>();
        public List<FB_XingHunUnitBase> ListData
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
        public FB_XingHunUnitBase GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_XingHunUnitBase);
        }
        public Dictionary<int, FB_XingHunUnitBase> GetData()
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
            if (!FB_XingHunUnitBaseContainer.FB_XingHunUnitBaseContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_XingHunUnitBaseContainer.GetRootAsFB_XingHunUnitBaseContainer(bb);
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
