using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_JiLingQiLingBaseProvider
    {
        private static FB_JiLingQiLingBaseProvider _Instance;
        public static FB_JiLingQiLingBaseProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_JiLingQiLingBaseProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/JiLingQiLingBase.txt";
        protected Dictionary<int, FB_JiLingQiLingBase> mData = new Dictionary<int, FB_JiLingQiLingBase>();
        private List<FB_JiLingQiLingBase> mListData = new List<FB_JiLingQiLingBase>();
        public List<FB_JiLingQiLingBase> ListData
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
        public FB_JiLingQiLingBase GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_JiLingQiLingBase);
        }
        public Dictionary<int, FB_JiLingQiLingBase> GetData()
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
            if (!FB_JiLingQiLingBaseContainer.FB_JiLingQiLingBaseContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_JiLingQiLingBaseContainer.GetRootAsFB_JiLingQiLingBaseContainer(bb);
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
