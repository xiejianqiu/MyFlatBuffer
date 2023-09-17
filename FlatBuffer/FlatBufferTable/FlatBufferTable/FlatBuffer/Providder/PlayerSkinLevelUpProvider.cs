using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_PlayerSkinLevelUpProvider
    {
        private static FB_PlayerSkinLevelUpProvider _Instance;
        public static FB_PlayerSkinLevelUpProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_PlayerSkinLevelUpProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/PlayerSkinLevelUp.txt";
        protected Dictionary<int, FB_PlayerSkinLevelUp> mData = new Dictionary<int, FB_PlayerSkinLevelUp>();
        private List<FB_PlayerSkinLevelUp> mListData = new List<FB_PlayerSkinLevelUp>();
        public List<FB_PlayerSkinLevelUp> ListData
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
        public FB_PlayerSkinLevelUp GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_PlayerSkinLevelUp);
        }
        public Dictionary<int, FB_PlayerSkinLevelUp> GetData()
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
            if (!FB_PlayerSkinLevelUpContainer.FB_PlayerSkinLevelUpContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_PlayerSkinLevelUpContainer.GetRootAsFB_PlayerSkinLevelUpContainer(bb);
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
