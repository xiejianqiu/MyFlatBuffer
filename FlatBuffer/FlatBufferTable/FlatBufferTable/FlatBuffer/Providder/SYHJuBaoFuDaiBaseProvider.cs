using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_SYHJuBaoFuDaiBaseProvider
    {
        private static FB_SYHJuBaoFuDaiBaseProvider _Instance;
        public static FB_SYHJuBaoFuDaiBaseProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_SYHJuBaoFuDaiBaseProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/SYHJuBaoFuDaiBase.txt";
        protected Dictionary<int, FB_SYHJuBaoFuDaiBase> mData = new Dictionary<int, FB_SYHJuBaoFuDaiBase>();
        private List<FB_SYHJuBaoFuDaiBase> mListData = new List<FB_SYHJuBaoFuDaiBase>();
        public List<FB_SYHJuBaoFuDaiBase> ListData
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
        public FB_SYHJuBaoFuDaiBase GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_SYHJuBaoFuDaiBase);
        }
        public Dictionary<int, FB_SYHJuBaoFuDaiBase> GetData()
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
            if (!FB_SYHJuBaoFuDaiBaseContainer.FB_SYHJuBaoFuDaiBaseContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_SYHJuBaoFuDaiBaseContainer.GetRootAsFB_SYHJuBaoFuDaiBaseContainer(bb);
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
