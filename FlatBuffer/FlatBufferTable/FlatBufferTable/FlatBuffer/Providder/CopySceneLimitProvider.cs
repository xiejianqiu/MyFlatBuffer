using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_CopySceneLimitProvider
    {
        private static FB_CopySceneLimitProvider _Instance;
        public static FB_CopySceneLimitProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_CopySceneLimitProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/CopySceneLimit.txt";
        protected Dictionary<int, FB_CopySceneLimit> mData = new Dictionary<int, FB_CopySceneLimit>();
        private List<FB_CopySceneLimit> mListData = new List<FB_CopySceneLimit>();
        public List<FB_CopySceneLimit> ListData
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
        public FB_CopySceneLimit GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_CopySceneLimit);
        }
        public Dictionary<int, FB_CopySceneLimit> GetData()
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
            if (!FB_CopySceneLimitContainer.FB_CopySceneLimitContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_CopySceneLimitContainer.GetRootAsFB_CopySceneLimitContainer(bb);
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
