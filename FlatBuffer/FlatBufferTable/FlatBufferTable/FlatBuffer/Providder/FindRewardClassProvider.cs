using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_FindRewardClassProvider
    {
        private static FB_FindRewardClassProvider _Instance;
        public static FB_FindRewardClassProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_FindRewardClassProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/FindRewardClass.txt";
        protected Dictionary<int, FB_FindRewardClass> mData = new Dictionary<int, FB_FindRewardClass>();
        private List<FB_FindRewardClass> mListData = new List<FB_FindRewardClass>();
        public List<FB_FindRewardClass> ListData
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
        public FB_FindRewardClass GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_FindRewardClass);
        }
        public Dictionary<int, FB_FindRewardClass> GetData()
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
            if (!FB_FindRewardClassContainer.FB_FindRewardClassContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_FindRewardClassContainer.GetRootAsFB_FindRewardClassContainer(bb);
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
