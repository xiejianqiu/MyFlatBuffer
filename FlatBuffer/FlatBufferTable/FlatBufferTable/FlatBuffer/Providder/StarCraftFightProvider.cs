using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_StarCraftFightProvider
    {
        private static FB_StarCraftFightProvider _Instance;
        public static FB_StarCraftFightProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_StarCraftFightProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/StarCraftFight.txt";
        protected Dictionary<int, FB_StarCraftFight> mData = new Dictionary<int, FB_StarCraftFight>();
        private List<FB_StarCraftFight> mListData = new List<FB_StarCraftFight>();
        public List<FB_StarCraftFight> ListData
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
        public FB_StarCraftFight GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_StarCraftFight);
        }
        public Dictionary<int, FB_StarCraftFight> GetData()
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
            if (!FB_StarCraftFightContainer.FB_StarCraftFightContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_StarCraftFightContainer.GetRootAsFB_StarCraftFightContainer(bb);
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
