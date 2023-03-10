using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_SYHYuanBaoInvestTypeProvider
    {
        private static FB_SYHYuanBaoInvestTypeProvider _Instance;
        public static FB_SYHYuanBaoInvestTypeProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_SYHYuanBaoInvestTypeProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/SYHYuanBaoInvestType.txt";
        protected Dictionary<int, FB_SYHYuanBaoInvestType> mData = new Dictionary<int, FB_SYHYuanBaoInvestType>();
        private List<FB_SYHYuanBaoInvestType> mListData = new List<FB_SYHYuanBaoInvestType>();
        public List<FB_SYHYuanBaoInvestType> ListData
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
        public FB_SYHYuanBaoInvestType GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_SYHYuanBaoInvestType);
        }
        public Dictionary<int, FB_SYHYuanBaoInvestType> GetData()
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
            if (!FB_SYHYuanBaoInvestTypeContainer.FB_SYHYuanBaoInvestTypeContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_SYHYuanBaoInvestTypeContainer.GetRootAsFB_SYHYuanBaoInvestTypeContainer(bb);
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
