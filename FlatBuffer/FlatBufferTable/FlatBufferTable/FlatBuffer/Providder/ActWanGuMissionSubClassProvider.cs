using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_ActWanGuMissionSubClassProvider
    {
        private static FB_ActWanGuMissionSubClassProvider _Instance;
        public static FB_ActWanGuMissionSubClassProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_ActWanGuMissionSubClassProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/ActWanGuMissionSubClass.txt";
        protected Dictionary<int, FB_ActWanGuMissionSubClass> mData = new Dictionary<int, FB_ActWanGuMissionSubClass>();
        private List<FB_ActWanGuMissionSubClass> mListData = new List<FB_ActWanGuMissionSubClass>();
        public List<FB_ActWanGuMissionSubClass> ListData
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
        public FB_ActWanGuMissionSubClass GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_ActWanGuMissionSubClass);
        }
        public Dictionary<int, FB_ActWanGuMissionSubClass> GetData()
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
            if (!FB_ActWanGuMissionSubClassContainer.FB_ActWanGuMissionSubClassContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_ActWanGuMissionSubClassContainer.GetRootAsFB_ActWanGuMissionSubClassContainer(bb);
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
