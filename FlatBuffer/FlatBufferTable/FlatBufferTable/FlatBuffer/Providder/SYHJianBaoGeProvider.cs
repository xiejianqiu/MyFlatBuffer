using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_SYHJianBaoGeProvider
    {
        private static FB_SYHJianBaoGeProvider _Instance;
        public static FB_SYHJianBaoGeProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_SYHJianBaoGeProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/SYHJianBaoGe.txt";
        protected Dictionary<int, FB_SYHJianBaoGe> mData = new Dictionary<int, FB_SYHJianBaoGe>();
        private List<FB_SYHJianBaoGe> mListData = new List<FB_SYHJianBaoGe>();
        public List<FB_SYHJianBaoGe> ListData
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
        public FB_SYHJianBaoGe GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_SYHJianBaoGe);
        }
        public Dictionary<int, FB_SYHJianBaoGe> GetData()
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
            if (!FB_SYHJianBaoGeContainer.FB_SYHJianBaoGeContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_SYHJianBaoGeContainer.GetRootAsFB_SYHJianBaoGeContainer(bb);
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
