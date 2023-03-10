using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_HunJiangItemBaseProvider
    {
        private static FB_HunJiangItemBaseProvider _Instance;
        public static FB_HunJiangItemBaseProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_HunJiangItemBaseProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/HunJiangItemBase.txt";
        protected Dictionary<int, FB_HunJiangItemBase> mData = new Dictionary<int, FB_HunJiangItemBase>();
        private List<FB_HunJiangItemBase> mListData = new List<FB_HunJiangItemBase>();
        public List<FB_HunJiangItemBase> ListData
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
        public FB_HunJiangItemBase GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_HunJiangItemBase);
        }
        public Dictionary<int, FB_HunJiangItemBase> GetData()
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
            if (!FB_HunJiangItemBaseContainer.FB_HunJiangItemBaseContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_HunJiangItemBaseContainer.GetRootAsFB_HunJiangItemBaseContainer(bb);
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
