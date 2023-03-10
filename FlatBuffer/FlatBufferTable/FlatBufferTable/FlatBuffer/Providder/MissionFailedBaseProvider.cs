using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_MissionFailedBaseProvider
    {
        private static FB_MissionFailedBaseProvider _Instance;
        public static FB_MissionFailedBaseProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_MissionFailedBaseProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/MissionFailedBase.txt";
        protected Dictionary<int, FB_MissionFailedBase> mData = new Dictionary<int, FB_MissionFailedBase>();
        private List<FB_MissionFailedBase> mListData = new List<FB_MissionFailedBase>();
        public List<FB_MissionFailedBase> ListData
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
        public FB_MissionFailedBase GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_MissionFailedBase);
        }
        public Dictionary<int, FB_MissionFailedBase> GetData()
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
            if (!FB_MissionFailedBaseContainer.FB_MissionFailedBaseContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_MissionFailedBaseContainer.GetRootAsFB_MissionFailedBaseContainer(bb);
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
