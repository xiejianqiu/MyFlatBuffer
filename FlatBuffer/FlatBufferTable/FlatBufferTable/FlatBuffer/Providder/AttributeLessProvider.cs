using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_AttributeLessProvider
    {
        private static FB_AttributeLessProvider _Instance;
        public static FB_AttributeLessProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_AttributeLessProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Client/AttributeLess.txt";
        protected Dictionary<int, FB_AttributeLess> mData = new Dictionary<int, FB_AttributeLess>();
        private List<FB_AttributeLess> mListData = new List<FB_AttributeLess>();
        public List<FB_AttributeLess> ListData
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
        public FB_AttributeLess GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_AttributeLess);
        }
        public Dictionary<int, FB_AttributeLess> GetData()
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
            if (!FB_AttributeLessContainer.FB_AttributeLessContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_AttributeLessContainer.GetRootAsFB_AttributeLessContainer(bb);
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
