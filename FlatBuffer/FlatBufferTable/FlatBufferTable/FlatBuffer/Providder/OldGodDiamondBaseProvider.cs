using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_OldGodDiamondBaseProvider
    {
        private static FB_OldGodDiamondBaseProvider _Instance;
        public static FB_OldGodDiamondBaseProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_OldGodDiamondBaseProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/OldGodDiamondBase.txt";
        protected Dictionary<int, FB_OldGodDiamondBase> mData = new Dictionary<int, FB_OldGodDiamondBase>();
        private List<FB_OldGodDiamondBase> mListData = new List<FB_OldGodDiamondBase>();
        public List<FB_OldGodDiamondBase> ListData
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
        public FB_OldGodDiamondBase GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_OldGodDiamondBase);
        }
        public Dictionary<int, FB_OldGodDiamondBase> GetData()
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
            if (!FB_OldGodDiamondBaseContainer.FB_OldGodDiamondBaseContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_OldGodDiamondBaseContainer.GetRootAsFB_OldGodDiamondBaseContainer(bb);
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
