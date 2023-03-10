using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_PlayerSkinBaseProvider
    {
        private static FB_PlayerSkinBaseProvider _Instance;
        public static FB_PlayerSkinBaseProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_PlayerSkinBaseProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/PlayerSkinBase.txt";
        protected Dictionary<int, FB_PlayerSkinBase> mData = new Dictionary<int, FB_PlayerSkinBase>();
        private List<FB_PlayerSkinBase> mListData = new List<FB_PlayerSkinBase>();
        public List<FB_PlayerSkinBase> ListData
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
        public FB_PlayerSkinBase GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_PlayerSkinBase);
        }
        public Dictionary<int, FB_PlayerSkinBase> GetData()
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
            if (!FB_PlayerSkinBaseContainer.FB_PlayerSkinBaseContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_PlayerSkinBaseContainer.GetRootAsFB_PlayerSkinBaseContainer(bb);
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
