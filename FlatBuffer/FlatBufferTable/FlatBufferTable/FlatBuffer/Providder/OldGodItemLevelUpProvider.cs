using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_OldGodItemLevelUpProvider
    {
        private static FB_OldGodItemLevelUpProvider _Instance;
        public static FB_OldGodItemLevelUpProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_OldGodItemLevelUpProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/OldGodItemLevelUp.txt";
        protected Dictionary<int, FB_OldGodItemLevelUp> mData = new Dictionary<int, FB_OldGodItemLevelUp>();
        private List<FB_OldGodItemLevelUp> mListData = new List<FB_OldGodItemLevelUp>();
        public List<FB_OldGodItemLevelUp> ListData
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
        public FB_OldGodItemLevelUp GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_OldGodItemLevelUp);
        }
        public Dictionary<int, FB_OldGodItemLevelUp> GetData()
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
            if (!FB_OldGodItemLevelUpContainer.FB_OldGodItemLevelUpContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_OldGodItemLevelUpContainer.GetRootAsFB_OldGodItemLevelUpContainer(bb);
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
