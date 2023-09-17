using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_ActivityBonusProvider
    {
        private static FB_ActivityBonusProvider _Instance;
        public static FB_ActivityBonusProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_ActivityBonusProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/ActivityBonus.txt";
        protected Dictionary<int, FB_ActivityBonus> mData = new Dictionary<int, FB_ActivityBonus>();
        private List<FB_ActivityBonus> mListData = new List<FB_ActivityBonus>();
        public List<FB_ActivityBonus> ListData
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
        public FB_ActivityBonus GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_ActivityBonus);
        }
        public Dictionary<int, FB_ActivityBonus> GetData()
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
            if (!FB_ActivityBonusContainer.FB_ActivityBonusContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_ActivityBonusContainer.GetRootAsFB_ActivityBonusContainer(bb);
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
