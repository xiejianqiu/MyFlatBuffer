using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_BenYuanItemBaseProvider
    {
        private static FB_BenYuanItemBaseProvider _Instance;
        public static FB_BenYuanItemBaseProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_BenYuanItemBaseProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/BenYuanItemBase.txt";
        protected Dictionary<int, FB_BenYuanItemBase> mData = new Dictionary<int, FB_BenYuanItemBase>();
        private List<FB_BenYuanItemBase> mListData = new List<FB_BenYuanItemBase>();
        public List<FB_BenYuanItemBase> ListData
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
        public FB_BenYuanItemBase GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_BenYuanItemBase);
        }
        public Dictionary<int, FB_BenYuanItemBase> GetData()
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
            if (!FB_BenYuanItemBaseContainer.FB_BenYuanItemBaseContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_BenYuanItemBaseContainer.GetRootAsFB_BenYuanItemBaseContainer(bb);
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
