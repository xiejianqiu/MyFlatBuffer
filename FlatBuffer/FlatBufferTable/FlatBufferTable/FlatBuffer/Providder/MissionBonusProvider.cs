using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_MissionBonusProvider
    {
        private static FB_MissionBonusProvider _Instance;
        public static FB_MissionBonusProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_MissionBonusProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/MissionBonus.txt";
        protected Dictionary<int, FB_MissionBonus> mData = new Dictionary<int, FB_MissionBonus>();
        private List<FB_MissionBonus> mListData = new List<FB_MissionBonus>();
        public List<FB_MissionBonus> ListData
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
        public FB_MissionBonus GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_MissionBonus);
        }
        public Dictionary<int, FB_MissionBonus> GetData()
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
            if (!FB_MissionBonusContainer.FB_MissionBonusContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_MissionBonusContainer.GetRootAsFB_MissionBonusContainer(bb);
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
