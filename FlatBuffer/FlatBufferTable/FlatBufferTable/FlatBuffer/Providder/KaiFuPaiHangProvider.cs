using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_KaiFuPaiHangProvider
    {
        private static FB_KaiFuPaiHangProvider _Instance;
        public static FB_KaiFuPaiHangProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_KaiFuPaiHangProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/KaiFuPaiHang.txt";
        protected Dictionary<int, FB_KaiFuPaiHang> mData = new Dictionary<int, FB_KaiFuPaiHang>();
        private List<FB_KaiFuPaiHang> mListData = new List<FB_KaiFuPaiHang>();
        public List<FB_KaiFuPaiHang> ListData
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
        public FB_KaiFuPaiHang GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_KaiFuPaiHang);
        }
        public Dictionary<int, FB_KaiFuPaiHang> GetData()
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
            if (!FB_KaiFuPaiHangContainer.FB_KaiFuPaiHangContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_KaiFuPaiHangContainer.GetRootAsFB_KaiFuPaiHangContainer(bb);
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
