using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_RechargeAndConsumeBaseProvider
    {
        private static FB_RechargeAndConsumeBaseProvider _Instance;
        public static FB_RechargeAndConsumeBaseProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_RechargeAndConsumeBaseProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/RechargeAndConsumeBase.txt";
        protected Dictionary<int, FB_RechargeAndConsumeBase> mData = new Dictionary<int, FB_RechargeAndConsumeBase>();
        private List<FB_RechargeAndConsumeBase> mListData = new List<FB_RechargeAndConsumeBase>();
        public List<FB_RechargeAndConsumeBase> ListData
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
        public FB_RechargeAndConsumeBase GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_RechargeAndConsumeBase);
        }
        public Dictionary<int, FB_RechargeAndConsumeBase> GetData()
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
            if (!FB_RechargeAndConsumeBaseContainer.FB_RechargeAndConsumeBaseContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_RechargeAndConsumeBaseContainer.GetRootAsFB_RechargeAndConsumeBaseContainer(bb);
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
