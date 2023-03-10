using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_LadderProvider
    {
        private static FB_LadderProvider _Instance;
        public static FB_LadderProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_LadderProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/Ladder.txt";
        protected Dictionary<int, FB_Ladder> mData = new Dictionary<int, FB_Ladder>();
        private List<FB_Ladder> mListData = new List<FB_Ladder>();
        public List<FB_Ladder> ListData
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
        public FB_Ladder GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_Ladder);
        }
        public Dictionary<int, FB_Ladder> GetData()
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
            if (!FB_LadderContainer.FB_LadderContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_LadderContainer.GetRootAsFB_LadderContainer(bb);
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
