using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_HunJiangGongMingProvider
    {
        private static FB_HunJiangGongMingProvider _Instance;
        public static FB_HunJiangGongMingProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_HunJiangGongMingProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/HunJiangGongMing.txt";
        protected Dictionary<int, FB_HunJiangGongMing> mData = new Dictionary<int, FB_HunJiangGongMing>();
        private List<FB_HunJiangGongMing> mListData = new List<FB_HunJiangGongMing>();
        public List<FB_HunJiangGongMing> ListData
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
        public FB_HunJiangGongMing GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_HunJiangGongMing);
        }
        public Dictionary<int, FB_HunJiangGongMing> GetData()
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
            if (!FB_HunJiangGongMingContainer.FB_HunJiangGongMingContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_HunJiangGongMingContainer.GetRootAsFB_HunJiangGongMingContainer(bb);
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
