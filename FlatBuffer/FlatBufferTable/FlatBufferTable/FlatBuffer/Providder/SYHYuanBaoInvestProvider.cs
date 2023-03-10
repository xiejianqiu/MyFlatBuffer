using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_SYHYuanBaoInvestProvider
    {
        private static FB_SYHYuanBaoInvestProvider _Instance;
        public static FB_SYHYuanBaoInvestProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_SYHYuanBaoInvestProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/SYHYuanBaoInvest.txt";
        protected Dictionary<int, FB_SYHYuanBaoInvest> mData = new Dictionary<int, FB_SYHYuanBaoInvest>();
        private List<FB_SYHYuanBaoInvest> mListData = new List<FB_SYHYuanBaoInvest>();
        public List<FB_SYHYuanBaoInvest> ListData
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
        public FB_SYHYuanBaoInvest GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_SYHYuanBaoInvest);
        }
        public Dictionary<int, FB_SYHYuanBaoInvest> GetData()
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
            if (!FB_SYHYuanBaoInvestContainer.FB_SYHYuanBaoInvestContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_SYHYuanBaoInvestContainer.GetRootAsFB_SYHYuanBaoInvestContainer(bb);
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
