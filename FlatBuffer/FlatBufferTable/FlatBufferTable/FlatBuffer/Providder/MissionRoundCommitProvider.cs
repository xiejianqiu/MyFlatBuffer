using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_MissionRoundCommitProvider
    {
        private static FB_MissionRoundCommitProvider _Instance;
        public static FB_MissionRoundCommitProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_MissionRoundCommitProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/MissionRoundCommit.txt";
        protected Dictionary<int, FB_MissionRoundCommit> mData = new Dictionary<int, FB_MissionRoundCommit>();
        private List<FB_MissionRoundCommit> mListData = new List<FB_MissionRoundCommit>();
        public List<FB_MissionRoundCommit> ListData
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
        public FB_MissionRoundCommit GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_MissionRoundCommit);
        }
        public Dictionary<int, FB_MissionRoundCommit> GetData()
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
            if (!FB_MissionRoundCommitContainer.FB_MissionRoundCommitContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_MissionRoundCommitContainer.GetRootAsFB_MissionRoundCommitContainer(bb);
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
