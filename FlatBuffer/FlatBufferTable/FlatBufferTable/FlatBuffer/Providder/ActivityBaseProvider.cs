using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_ActivityBaseProvider
    {
        private static FB_ActivityBaseProvider _Instance;
        public static FB_ActivityBaseProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_ActivityBaseProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/ActivityBase.txt";
        protected Dictionary<int, FB_ActivityBase> mData = new Dictionary<int, FB_ActivityBase>();
        private List<FB_ActivityBase> mListData = new List<FB_ActivityBase>();
        public List<FB_ActivityBase> ListData
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
        public FB_ActivityBase GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_ActivityBase);
        }
        public Dictionary<int, FB_ActivityBase> GetData()
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
            if (!FB_ActivityBaseContainer.FB_ActivityBaseContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_ActivityBaseContainer.GetRootAsFB_ActivityBaseContainer(bb);
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
