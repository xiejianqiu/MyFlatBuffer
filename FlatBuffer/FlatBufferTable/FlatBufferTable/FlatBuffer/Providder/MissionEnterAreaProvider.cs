using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_MissionEnterAreaProvider
    {
        private static FB_MissionEnterAreaProvider _Instance;
        public static FB_MissionEnterAreaProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_MissionEnterAreaProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/MissionEnterArea.txt";
        protected Dictionary<int, FB_MissionEnterArea> mData = new Dictionary<int, FB_MissionEnterArea>();
        private List<FB_MissionEnterArea> mListData = new List<FB_MissionEnterArea>();
        public List<FB_MissionEnterArea> ListData
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
        public FB_MissionEnterArea GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_MissionEnterArea);
        }
        public Dictionary<int, FB_MissionEnterArea> GetData()
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
            if (!FB_MissionEnterAreaContainer.FB_MissionEnterAreaContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_MissionEnterAreaContainer.GetRootAsFB_MissionEnterAreaContainer(bb);
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
