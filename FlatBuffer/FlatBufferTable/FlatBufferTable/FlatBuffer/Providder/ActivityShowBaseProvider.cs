using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_ActivityShowBaseProvider
    {
        private static FB_ActivityShowBaseProvider _Instance;
        public static FB_ActivityShowBaseProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_ActivityShowBaseProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/ActivityShowBase.txt";
        protected Dictionary<int, FB_ActivityShowBase> mData = new Dictionary<int, FB_ActivityShowBase>();
        private List<FB_ActivityShowBase> mListData = new List<FB_ActivityShowBase>();
        public List<FB_ActivityShowBase> ListData
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
        public FB_ActivityShowBase GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_ActivityShowBase);
        }
        public Dictionary<int, FB_ActivityShowBase> GetData()
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
            if (!FB_ActivityShowBaseContainer.FB_ActivityShowBaseContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_ActivityShowBaseContainer.GetRootAsFB_ActivityShowBaseContainer(bb);
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