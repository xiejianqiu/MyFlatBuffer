using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_XingYuPaiHangProvider
    {
        private static FB_XingYuPaiHangProvider _Instance;
        public static FB_XingYuPaiHangProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_XingYuPaiHangProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/XingYuPaiHang.txt";
        protected Dictionary<int, FB_XingYuPaiHang> mData = new Dictionary<int, FB_XingYuPaiHang>();
        private List<FB_XingYuPaiHang> mListData = new List<FB_XingYuPaiHang>();
        public List<FB_XingYuPaiHang> ListData
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
        public FB_XingYuPaiHang GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_XingYuPaiHang);
        }
        public Dictionary<int, FB_XingYuPaiHang> GetData()
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
            if (!FB_XingYuPaiHangContainer.FB_XingYuPaiHangContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_XingYuPaiHangContainer.GetRootAsFB_XingYuPaiHangContainer(bb);
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
