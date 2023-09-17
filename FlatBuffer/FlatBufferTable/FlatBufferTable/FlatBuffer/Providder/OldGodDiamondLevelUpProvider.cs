using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_OldGodDiamondLevelUpProvider
    {
        private static FB_OldGodDiamondLevelUpProvider _Instance;
        public static FB_OldGodDiamondLevelUpProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_OldGodDiamondLevelUpProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/OldGodDiamondLevelUp.txt";
        protected Dictionary<int, FB_OldGodDiamondLevelUp> mData = new Dictionary<int, FB_OldGodDiamondLevelUp>();
        private List<FB_OldGodDiamondLevelUp> mListData = new List<FB_OldGodDiamondLevelUp>();
        public List<FB_OldGodDiamondLevelUp> ListData
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
        public FB_OldGodDiamondLevelUp GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_OldGodDiamondLevelUp);
        }
        public Dictionary<int, FB_OldGodDiamondLevelUp> GetData()
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
            if (!FB_OldGodDiamondLevelUpContainer.FB_OldGodDiamondLevelUpContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_OldGodDiamondLevelUpContainer.GetRootAsFB_OldGodDiamondLevelUpContainer(bb);
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
