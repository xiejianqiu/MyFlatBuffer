using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_SYHTianXingBaoGeProvider
    {
        private static FB_SYHTianXingBaoGeProvider _Instance;
        public static FB_SYHTianXingBaoGeProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_SYHTianXingBaoGeProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/SYHTianXingBaoGe.txt";
        protected Dictionary<int, FB_SYHTianXingBaoGe> mData = new Dictionary<int, FB_SYHTianXingBaoGe>();
        private List<FB_SYHTianXingBaoGe> mListData = new List<FB_SYHTianXingBaoGe>();
        public List<FB_SYHTianXingBaoGe> ListData
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
        public FB_SYHTianXingBaoGe GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_SYHTianXingBaoGe);
        }
        public Dictionary<int, FB_SYHTianXingBaoGe> GetData()
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
            if (!FB_SYHTianXingBaoGeContainer.FB_SYHTianXingBaoGeContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_SYHTianXingBaoGeContainer.GetRootAsFB_SYHTianXingBaoGeContainer(bb);
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
