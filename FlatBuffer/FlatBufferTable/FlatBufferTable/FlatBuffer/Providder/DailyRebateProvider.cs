using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_DailyRebateProvider
    {
        private static FB_DailyRebateProvider _Instance;
        public static FB_DailyRebateProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_DailyRebateProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/DailyRebate.txt";
        protected Dictionary<int, FB_DailyRebate> mData = new Dictionary<int, FB_DailyRebate>();
        private List<FB_DailyRebate> mListData = new List<FB_DailyRebate>();
        public List<FB_DailyRebate> ListData
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
        public FB_DailyRebate GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_DailyRebate);
        }
        public Dictionary<int, FB_DailyRebate> GetData()
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
            if (!FB_DailyRebateContainer.FB_DailyRebateContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_DailyRebateContainer.GetRootAsFB_DailyRebateContainer(bb);
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