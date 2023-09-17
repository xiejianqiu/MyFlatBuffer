using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_KaiFuPaiHangTypeProvider
    {
        private static FB_KaiFuPaiHangTypeProvider _Instance;
        public static FB_KaiFuPaiHangTypeProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_KaiFuPaiHangTypeProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/KaiFuPaiHangType.txt";
        protected Dictionary<int, FB_KaiFuPaiHangType> mData = new Dictionary<int, FB_KaiFuPaiHangType>();
        private List<FB_KaiFuPaiHangType> mListData = new List<FB_KaiFuPaiHangType>();
        public List<FB_KaiFuPaiHangType> ListData
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
        public FB_KaiFuPaiHangType GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_KaiFuPaiHangType);
        }
        public Dictionary<int, FB_KaiFuPaiHangType> GetData()
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
            if (!FB_KaiFuPaiHangTypeContainer.FB_KaiFuPaiHangTypeContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_KaiFuPaiHangTypeContainer.GetRootAsFB_KaiFuPaiHangTypeContainer(bb);
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
