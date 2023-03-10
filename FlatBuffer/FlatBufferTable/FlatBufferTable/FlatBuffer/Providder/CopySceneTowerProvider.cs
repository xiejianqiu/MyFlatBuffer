using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_CopySceneTowerProvider
    {
        private static FB_CopySceneTowerProvider _Instance;
        public static FB_CopySceneTowerProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_CopySceneTowerProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/CopySceneTower.txt";
        protected Dictionary<int, FB_CopySceneTower> mData = new Dictionary<int, FB_CopySceneTower>();
        private List<FB_CopySceneTower> mListData = new List<FB_CopySceneTower>();
        public List<FB_CopySceneTower> ListData
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
        public FB_CopySceneTower GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_CopySceneTower);
        }
        public Dictionary<int, FB_CopySceneTower> GetData()
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
            if (!FB_CopySceneTowerContainer.FB_CopySceneTowerContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_CopySceneTowerContainer.GetRootAsFB_CopySceneTowerContainer(bb);
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
