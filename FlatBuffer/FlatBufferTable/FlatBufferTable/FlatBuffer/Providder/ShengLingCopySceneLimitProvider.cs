using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_ShengLingCopySceneLimitProvider
    {
        private static FB_ShengLingCopySceneLimitProvider _Instance;
        public static FB_ShengLingCopySceneLimitProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_ShengLingCopySceneLimitProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/ShengLingCopySceneLimit.txt";
        protected Dictionary<int, FB_ShengLingCopySceneLimit> mData = new Dictionary<int, FB_ShengLingCopySceneLimit>();
        private List<FB_ShengLingCopySceneLimit> mListData = new List<FB_ShengLingCopySceneLimit>();
        public List<FB_ShengLingCopySceneLimit> ListData
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
        public FB_ShengLingCopySceneLimit GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_ShengLingCopySceneLimit);
        }
        public Dictionary<int, FB_ShengLingCopySceneLimit> GetData()
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
            if (!FB_ShengLingCopySceneLimitContainer.FB_ShengLingCopySceneLimitContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_ShengLingCopySceneLimitContainer.GetRootAsFB_ShengLingCopySceneLimitContainer(bb);
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
