using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_JiLingQiLingGongMingProvider
    {
        private static FB_JiLingQiLingGongMingProvider _Instance;
        public static FB_JiLingQiLingGongMingProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_JiLingQiLingGongMingProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/JiLingQiLingGongMing.txt";
        protected Dictionary<int, FB_JiLingQiLingGongMing> mData = new Dictionary<int, FB_JiLingQiLingGongMing>();
        private List<FB_JiLingQiLingGongMing> mListData = new List<FB_JiLingQiLingGongMing>();
        public List<FB_JiLingQiLingGongMing> ListData
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
        public FB_JiLingQiLingGongMing GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_JiLingQiLingGongMing);
        }
        public Dictionary<int, FB_JiLingQiLingGongMing> GetData()
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
            if (!FB_JiLingQiLingGongMingContainer.FB_JiLingQiLingGongMingContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_JiLingQiLingGongMingContainer.GetRootAsFB_JiLingQiLingGongMingContainer(bb);
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
