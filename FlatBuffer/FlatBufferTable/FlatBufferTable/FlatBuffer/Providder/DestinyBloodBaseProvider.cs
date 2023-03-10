using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_DestinyBloodBaseProvider
    {
        private static FB_DestinyBloodBaseProvider _Instance;
        public static FB_DestinyBloodBaseProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_DestinyBloodBaseProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/DestinyBloodBase.txt";
        protected Dictionary<int, FB_DestinyBloodBase> mData = new Dictionary<int, FB_DestinyBloodBase>();
        private List<FB_DestinyBloodBase> mListData = new List<FB_DestinyBloodBase>();
        public List<FB_DestinyBloodBase> ListData
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
        public FB_DestinyBloodBase GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_DestinyBloodBase);
        }
        public Dictionary<int, FB_DestinyBloodBase> GetData()
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
            if (!FB_DestinyBloodBaseContainer.FB_DestinyBloodBaseContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_DestinyBloodBaseContainer.GetRootAsFB_DestinyBloodBaseContainer(bb);
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
