using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_PlayerSkinColorProvider
    {
        private static FB_PlayerSkinColorProvider _Instance;
        public static FB_PlayerSkinColorProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_PlayerSkinColorProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/PlayerSkinColor.txt";
        protected Dictionary<int, FB_PlayerSkinColor> mData = new Dictionary<int, FB_PlayerSkinColor>();
        private List<FB_PlayerSkinColor> mListData = new List<FB_PlayerSkinColor>();
        public List<FB_PlayerSkinColor> ListData
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
        public FB_PlayerSkinColor GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_PlayerSkinColor);
        }
        public Dictionary<int, FB_PlayerSkinColor> GetData()
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
            if (!FB_PlayerSkinColorContainer.FB_PlayerSkinColorContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_PlayerSkinColorContainer.GetRootAsFB_PlayerSkinColorContainer(bb);
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
