using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_RunesTreasureBaseProvider
    {
        private static FB_RunesTreasureBaseProvider _Instance;
        public static FB_RunesTreasureBaseProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_RunesTreasureBaseProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/RunesTreasureBase.txt";
        protected Dictionary<int, FB_RunesTreasureBase> mData = new Dictionary<int, FB_RunesTreasureBase>();
        private List<FB_RunesTreasureBase> mListData = new List<FB_RunesTreasureBase>();
        public List<FB_RunesTreasureBase> ListData
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
        public FB_RunesTreasureBase GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_RunesTreasureBase);
        }
        public Dictionary<int, FB_RunesTreasureBase> GetData()
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
            if (!FB_RunesTreasureBaseContainer.FB_RunesTreasureBaseContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_RunesTreasureBaseContainer.GetRootAsFB_RunesTreasureBaseContainer(bb);
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
