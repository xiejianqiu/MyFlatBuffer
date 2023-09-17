using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_HunJiangJiBanBaseProvider
    {
        private static FB_HunJiangJiBanBaseProvider _Instance;
        public static FB_HunJiangJiBanBaseProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_HunJiangJiBanBaseProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/HunJiangJiBanBase.txt";
        protected Dictionary<int, FB_HunJiangJiBanBase> mData = new Dictionary<int, FB_HunJiangJiBanBase>();
        private List<FB_HunJiangJiBanBase> mListData = new List<FB_HunJiangJiBanBase>();
        public List<FB_HunJiangJiBanBase> ListData
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
        public FB_HunJiangJiBanBase GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_HunJiangJiBanBase);
        }
        public Dictionary<int, FB_HunJiangJiBanBase> GetData()
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
            if (!FB_HunJiangJiBanBaseContainer.FB_HunJiangJiBanBaseContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_HunJiangJiBanBaseContainer.GetRootAsFB_HunJiangJiBanBaseContainer(bb);
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
