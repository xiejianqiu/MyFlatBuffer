using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_XingHunItemBaseProvider
    {
        private static FB_XingHunItemBaseProvider _Instance;
        public static FB_XingHunItemBaseProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_XingHunItemBaseProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/XingHunItemBase.txt";
        protected Dictionary<int, FB_XingHunItemBase> mData = new Dictionary<int, FB_XingHunItemBase>();
        private List<FB_XingHunItemBase> mListData = new List<FB_XingHunItemBase>();
        public List<FB_XingHunItemBase> ListData
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
        public FB_XingHunItemBase GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_XingHunItemBase);
        }
        public Dictionary<int, FB_XingHunItemBase> GetData()
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
            if (!FB_XingHunItemBaseContainer.FB_XingHunItemBaseContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_XingHunItemBaseContainer.GetRootAsFB_XingHunItemBaseContainer(bb);
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
