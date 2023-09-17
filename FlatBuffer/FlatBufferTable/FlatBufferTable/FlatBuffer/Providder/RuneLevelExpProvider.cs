using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_RuneLevelExpProvider
    {
        private static FB_RuneLevelExpProvider _Instance;
        public static FB_RuneLevelExpProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_RuneLevelExpProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/RuneLevelExp.txt";
        protected Dictionary<int, FB_RuneLevelExp> mData = new Dictionary<int, FB_RuneLevelExp>();
        private List<FB_RuneLevelExp> mListData = new List<FB_RuneLevelExp>();
        public List<FB_RuneLevelExp> ListData
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
        public FB_RuneLevelExp GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_RuneLevelExp);
        }
        public Dictionary<int, FB_RuneLevelExp> GetData()
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
            if (!FB_RuneLevelExpContainer.FB_RuneLevelExpContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_RuneLevelExpContainer.GetRootAsFB_RuneLevelExpContainer(bb);
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
