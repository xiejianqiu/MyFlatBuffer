using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_RechargeNewProvider
    {
        private static FB_RechargeNewProvider _Instance;
        public static FB_RechargeNewProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_RechargeNewProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/RechargeNew.txt";
        protected Dictionary<int, FB_RechargeNew> mData = new Dictionary<int, FB_RechargeNew>();
        private List<FB_RechargeNew> mListData = new List<FB_RechargeNew>();
        public List<FB_RechargeNew> ListData
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
        public FB_RechargeNew GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_RechargeNew);
        }
        public Dictionary<int, FB_RechargeNew> GetData()
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
            if (!FB_RechargeNewContainer.FB_RechargeNewContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_RechargeNewContainer.GetRootAsFB_RechargeNewContainer(bb);
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
