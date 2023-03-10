using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_MissionRoundProvider
    {
        private static FB_MissionRoundProvider _Instance;
        public static FB_MissionRoundProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_MissionRoundProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/MissionRound.txt";
        protected Dictionary<int, FB_MissionRound> mData = new Dictionary<int, FB_MissionRound>();
        private List<FB_MissionRound> mListData = new List<FB_MissionRound>();
        public List<FB_MissionRound> ListData
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
        public FB_MissionRound GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_MissionRound);
        }
        public Dictionary<int, FB_MissionRound> GetData()
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
            if (!FB_MissionRoundContainer.FB_MissionRoundContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_MissionRoundContainer.GetRootAsFB_MissionRoundContainer(bb);
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
