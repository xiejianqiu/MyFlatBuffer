using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_JiLingJingJieProvider
    {
        private static FB_JiLingJingJieProvider _Instance;
        public static FB_JiLingJingJieProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_JiLingJingJieProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/JiLingJingJie.txt";
        protected Dictionary<int, FB_JiLingJingJie> mData = new Dictionary<int, FB_JiLingJingJie>();
        private List<FB_JiLingJingJie> mListData = new List<FB_JiLingJingJie>();
        public List<FB_JiLingJingJie> ListData
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
        public FB_JiLingJingJie GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_JiLingJingJie);
        }
        public Dictionary<int, FB_JiLingJingJie> GetData()
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
            if (!FB_JiLingJingJieContainer.FB_JiLingJingJieContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_JiLingJingJieContainer.GetRootAsFB_JiLingJingJieContainer(bb);
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
