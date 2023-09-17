using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_ItemCompoundBaseProvider
    {
        private static FB_ItemCompoundBaseProvider _Instance;
        public static FB_ItemCompoundBaseProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_ItemCompoundBaseProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/ItemCompoundBase.txt";
        protected Dictionary<int, FB_ItemCompoundBase> mData = new Dictionary<int, FB_ItemCompoundBase>();
        private List<FB_ItemCompoundBase> mListData = new List<FB_ItemCompoundBase>();
        public List<FB_ItemCompoundBase> ListData
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
        public FB_ItemCompoundBase GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_ItemCompoundBase);
        }
        public Dictionary<int, FB_ItemCompoundBase> GetData()
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
            if (!FB_ItemCompoundBaseContainer.FB_ItemCompoundBaseContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_ItemCompoundBaseContainer.GetRootAsFB_ItemCompoundBaseContainer(bb);
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
