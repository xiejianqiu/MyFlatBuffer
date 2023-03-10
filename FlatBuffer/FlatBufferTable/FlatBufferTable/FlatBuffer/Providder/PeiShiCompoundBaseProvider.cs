using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_PeiShiCompoundBaseProvider
    {
        private static FB_PeiShiCompoundBaseProvider _Instance;
        public static FB_PeiShiCompoundBaseProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_PeiShiCompoundBaseProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/PeiShiCompoundBase.txt";
        protected Dictionary<int, FB_PeiShiCompoundBase> mData = new Dictionary<int, FB_PeiShiCompoundBase>();
        private List<FB_PeiShiCompoundBase> mListData = new List<FB_PeiShiCompoundBase>();
        public List<FB_PeiShiCompoundBase> ListData
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
        public FB_PeiShiCompoundBase GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_PeiShiCompoundBase);
        }
        public Dictionary<int, FB_PeiShiCompoundBase> GetData()
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
            if (!FB_PeiShiCompoundBaseContainer.FB_PeiShiCompoundBaseContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_PeiShiCompoundBaseContainer.GetRootAsFB_PeiShiCompoundBaseContainer(bb);
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
