using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_DestinyTemperBaseProvider
    {
        private static FB_DestinyTemperBaseProvider _Instance;
        public static FB_DestinyTemperBaseProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_DestinyTemperBaseProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/DestinyTemperBase.txt";
        protected Dictionary<int, FB_DestinyTemperBase> mData = new Dictionary<int, FB_DestinyTemperBase>();
        private List<FB_DestinyTemperBase> mListData = new List<FB_DestinyTemperBase>();
        public List<FB_DestinyTemperBase> ListData
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
        public FB_DestinyTemperBase GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_DestinyTemperBase);
        }
        public Dictionary<int, FB_DestinyTemperBase> GetData()
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
            if (!FB_DestinyTemperBaseContainer.FB_DestinyTemperBaseContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_DestinyTemperBaseContainer.GetRootAsFB_DestinyTemperBaseContainer(bb);
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