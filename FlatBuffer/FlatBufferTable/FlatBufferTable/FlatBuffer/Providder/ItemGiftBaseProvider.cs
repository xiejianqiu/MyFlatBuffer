using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_ItemGiftBaseProvider
    {
        private static FB_ItemGiftBaseProvider _Instance;
        public static FB_ItemGiftBaseProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_ItemGiftBaseProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/ItemGiftBase.txt";
        protected Dictionary<int, FB_ItemGiftBase> mData = new Dictionary<int, FB_ItemGiftBase>();
        private List<FB_ItemGiftBase> mListData = new List<FB_ItemGiftBase>();
        public List<FB_ItemGiftBase> ListData
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
        public FB_ItemGiftBase GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_ItemGiftBase);
        }
        public Dictionary<int, FB_ItemGiftBase> GetData()
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
            if (!FB_ItemGiftBaseContainer.FB_ItemGiftBaseContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_ItemGiftBaseContainer.GetRootAsFB_ItemGiftBaseContainer(bb);
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
