using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_ActWanGuMissionClassProvider
    {
        private static FB_ActWanGuMissionClassProvider _Instance;
        public static FB_ActWanGuMissionClassProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_ActWanGuMissionClassProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/ActWanGuMissionClass.txt";
        protected Dictionary<int, FB_ActWanGuMissionClass> mData = new Dictionary<int, FB_ActWanGuMissionClass>();
        private List<FB_ActWanGuMissionClass> mListData = new List<FB_ActWanGuMissionClass>();
        public List<FB_ActWanGuMissionClass> ListData
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
        public FB_ActWanGuMissionClass GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_ActWanGuMissionClass);
        }
        public Dictionary<int, FB_ActWanGuMissionClass> GetData()
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
            if (!FB_ActWanGuMissionClassContainer.FB_ActWanGuMissionClassContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_ActWanGuMissionClassContainer.GetRootAsFB_ActWanGuMissionClassContainer(bb);
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
