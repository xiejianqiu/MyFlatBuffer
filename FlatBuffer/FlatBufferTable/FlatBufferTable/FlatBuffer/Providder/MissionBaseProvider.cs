using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_MissionBaseProvider
    {
        private static FB_MissionBaseProvider _Instance;
        public static FB_MissionBaseProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_MissionBaseProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/MissionBase.txt";
        protected Dictionary<int, FB_MissionBase> mData = new Dictionary<int, FB_MissionBase>();
        private List<FB_MissionBase> mListData = new List<FB_MissionBase>();
        public List<FB_MissionBase> ListData
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
        public FB_MissionBase GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_MissionBase);
        }
        public Dictionary<int, FB_MissionBase> GetData()
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
            if (!FB_MissionBaseContainer.FB_MissionBaseContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_MissionBaseContainer.GetRootAsFB_MissionBaseContainer(bb);
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
