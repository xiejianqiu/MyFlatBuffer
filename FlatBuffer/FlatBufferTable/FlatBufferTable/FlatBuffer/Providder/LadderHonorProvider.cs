using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_LadderHonorProvider
    {
        private static FB_LadderHonorProvider _Instance;
        public static FB_LadderHonorProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_LadderHonorProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/LadderHonor.txt";
        protected Dictionary<int, FB_LadderHonor> mData = new Dictionary<int, FB_LadderHonor>();
        private List<FB_LadderHonor> mListData = new List<FB_LadderHonor>();
        public List<FB_LadderHonor> ListData
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
        public FB_LadderHonor GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_LadderHonor);
        }
        public Dictionary<int, FB_LadderHonor> GetData()
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
            if (!FB_LadderHonorContainer.FB_LadderHonorContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_LadderHonorContainer.GetRootAsFB_LadderHonorContainer(bb);
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
