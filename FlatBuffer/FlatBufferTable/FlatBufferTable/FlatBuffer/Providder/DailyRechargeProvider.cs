using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_DailyRechargeProvider
    {
        private static FB_DailyRechargeProvider _Instance;
        public static FB_DailyRechargeProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_DailyRechargeProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/DailyRecharge.txt";
        protected Dictionary<int, FB_DailyRecharge> mData = new Dictionary<int, FB_DailyRecharge>();
        private List<FB_DailyRecharge> mListData = new List<FB_DailyRecharge>();
        public List<FB_DailyRecharge> ListData
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
        public FB_DailyRecharge GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_DailyRecharge);
        }
        public Dictionary<int, FB_DailyRecharge> GetData()
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
            if (!FB_DailyRechargeContainer.FB_DailyRechargeContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_DailyRechargeContainer.GetRootAsFB_DailyRechargeContainer(bb);
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
