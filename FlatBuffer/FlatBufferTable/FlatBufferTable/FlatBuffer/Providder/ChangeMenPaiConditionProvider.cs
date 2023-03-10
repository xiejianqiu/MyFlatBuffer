using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_ChangeMenPaiConditionProvider
    {
        private static FB_ChangeMenPaiConditionProvider _Instance;
        public static FB_ChangeMenPaiConditionProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_ChangeMenPaiConditionProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/ChangeMenPaiCondition.txt";
        protected Dictionary<int, FB_ChangeMenPaiCondition> mData = new Dictionary<int, FB_ChangeMenPaiCondition>();
        private List<FB_ChangeMenPaiCondition> mListData = new List<FB_ChangeMenPaiCondition>();
        public List<FB_ChangeMenPaiCondition> ListData
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
        public FB_ChangeMenPaiCondition GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_ChangeMenPaiCondition);
        }
        public Dictionary<int, FB_ChangeMenPaiCondition> GetData()
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
            if (!FB_ChangeMenPaiConditionContainer.FB_ChangeMenPaiConditionContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_ChangeMenPaiConditionContainer.GetRootAsFB_ChangeMenPaiConditionContainer(bb);
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
