using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_XingYuPingFenProvider
    {
        private static FB_XingYuPingFenProvider _Instance;
        public static FB_XingYuPingFenProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_XingYuPingFenProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/XingYuPingFen.txt";
        protected Dictionary<int, FB_XingYuPingFen> mData = new Dictionary<int, FB_XingYuPingFen>();
        private List<FB_XingYuPingFen> mListData = new List<FB_XingYuPingFen>();
        public List<FB_XingYuPingFen> ListData
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
        public FB_XingYuPingFen GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_XingYuPingFen);
        }
        public Dictionary<int, FB_XingYuPingFen> GetData()
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
            if (!FB_XingYuPingFenContainer.FB_XingYuPingFenContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_XingYuPingFenContainer.GetRootAsFB_XingYuPingFenContainer(bb);
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
