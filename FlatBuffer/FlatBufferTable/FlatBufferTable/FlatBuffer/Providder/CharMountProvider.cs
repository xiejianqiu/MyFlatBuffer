using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_CharMountProvider
    {
        private static FB_CharMountProvider _Instance;
        public static FB_CharMountProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_CharMountProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Client/CharMount.txt";
        protected Dictionary<int, FB_CharMount> mData = new Dictionary<int, FB_CharMount>();
        private List<FB_CharMount> mListData = new List<FB_CharMount>();
        public List<FB_CharMount> ListData
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
        public FB_CharMount GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_CharMount);
        }
        public Dictionary<int, FB_CharMount> GetData()
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
            if (!FB_CharMountContainer.FB_CharMountContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_CharMountContainer.GetRootAsFB_CharMountContainer(bb);
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
