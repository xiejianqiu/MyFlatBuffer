using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_MissionRoundConfigProvider
    {
        private static FB_MissionRoundConfigProvider _Instance;
        public static FB_MissionRoundConfigProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_MissionRoundConfigProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/MissionRoundConfig.txt";
        protected Dictionary<int, FB_MissionRoundConfig> mData = new Dictionary<int, FB_MissionRoundConfig>();
        private List<FB_MissionRoundConfig> mListData = new List<FB_MissionRoundConfig>();
        public List<FB_MissionRoundConfig> ListData
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
        public FB_MissionRoundConfig GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_MissionRoundConfig);
        }
        public Dictionary<int, FB_MissionRoundConfig> GetData()
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
            if (!FB_MissionRoundConfigContainer.FB_MissionRoundConfigContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_MissionRoundConfigContainer.GetRootAsFB_MissionRoundConfigContainer(bb);
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
