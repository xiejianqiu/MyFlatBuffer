using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_TianCiHongFuBaseProvider
    {
        private static FB_TianCiHongFuBaseProvider _Instance;
        public static FB_TianCiHongFuBaseProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_TianCiHongFuBaseProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/TianCiHongFuBase.txt";
        protected Dictionary<int, FB_TianCiHongFuBase> mData = new Dictionary<int, FB_TianCiHongFuBase>();
        private List<FB_TianCiHongFuBase> mListData = new List<FB_TianCiHongFuBase>();
        public List<FB_TianCiHongFuBase> ListData
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
        public FB_TianCiHongFuBase GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_TianCiHongFuBase);
        }
        public Dictionary<int, FB_TianCiHongFuBase> GetData()
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
            if (!FB_TianCiHongFuBaseContainer.FB_TianCiHongFuBaseContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_TianCiHongFuBaseContainer.GetRootAsFB_TianCiHongFuBaseContainer(bb);
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
