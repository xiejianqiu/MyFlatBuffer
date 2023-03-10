using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_DestinyBaseProvider
    {
        private static FB_DestinyBaseProvider _Instance;
        public static FB_DestinyBaseProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_DestinyBaseProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/DestinyBase.txt";
        protected Dictionary<int, FB_DestinyBase> mData = new Dictionary<int, FB_DestinyBase>();
        private List<FB_DestinyBase> mListData = new List<FB_DestinyBase>();
        public List<FB_DestinyBase> ListData
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
        public FB_DestinyBase GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_DestinyBase);
        }
        public Dictionary<int, FB_DestinyBase> GetData()
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
            if (!FB_DestinyBaseContainer.FB_DestinyBaseContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_DestinyBaseContainer.GetRootAsFB_DestinyBaseContainer(bb);
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
