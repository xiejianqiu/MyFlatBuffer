using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_RebateRuleProvider
    {
        private static FB_RebateRuleProvider _Instance;
        public static FB_RebateRuleProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_RebateRuleProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/RebateRule.txt";
        protected Dictionary<int, FB_RebateRule> mData = new Dictionary<int, FB_RebateRule>();
        private List<FB_RebateRule> mListData = new List<FB_RebateRule>();
        public List<FB_RebateRule> ListData
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
        public FB_RebateRule GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_RebateRule);
        }
        public Dictionary<int, FB_RebateRule> GetData()
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
            if (!FB_RebateRuleContainer.FB_RebateRuleContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_RebateRuleContainer.GetRootAsFB_RebateRuleContainer(bb);
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
