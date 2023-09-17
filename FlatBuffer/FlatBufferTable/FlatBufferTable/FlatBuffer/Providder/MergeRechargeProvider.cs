using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_MergeRechargeProvider
    {
        private static FB_MergeRechargeProvider _Instance;
        public static FB_MergeRechargeProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_MergeRechargeProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/MergeRecharge.txt";
        protected Dictionary<int, FB_MergeRecharge> mData = new Dictionary<int, FB_MergeRecharge>();
        private List<FB_MergeRecharge> mListData = new List<FB_MergeRecharge>();
        public List<FB_MergeRecharge> ListData
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
        public FB_MergeRecharge GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_MergeRecharge);
        }
        public Dictionary<int, FB_MergeRecharge> GetData()
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
            if (!FB_MergeRechargeContainer.FB_MergeRechargeContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_MergeRechargeContainer.GetRootAsFB_MergeRechargeContainer(bb);
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
