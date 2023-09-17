using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_HuLingBaseProvider
    {
        private static FB_HuLingBaseProvider _Instance;
        public static FB_HuLingBaseProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_HuLingBaseProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/HuLingBase.txt";
        protected Dictionary<int, FB_HuLingBase> mData = new Dictionary<int, FB_HuLingBase>();
        private List<FB_HuLingBase> mListData = new List<FB_HuLingBase>();
        public List<FB_HuLingBase> ListData
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
        public FB_HuLingBase GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_HuLingBase);
        }
        public Dictionary<int, FB_HuLingBase> GetData()
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
            if (!FB_HuLingBaseContainer.FB_HuLingBaseContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_HuLingBaseContainer.GetRootAsFB_HuLingBaseContainer(bb);
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
