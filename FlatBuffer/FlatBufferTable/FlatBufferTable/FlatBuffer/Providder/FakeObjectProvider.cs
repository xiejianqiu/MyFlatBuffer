using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_FakeObjectProvider
    {
        private static FB_FakeObjectProvider _Instance;
        public static FB_FakeObjectProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_FakeObjectProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/FakeObject.txt";
        protected Dictionary<int, FB_FakeObject> mData = new Dictionary<int, FB_FakeObject>();
        private List<FB_FakeObject> mListData = new List<FB_FakeObject>();
        public List<FB_FakeObject> ListData
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
        public FB_FakeObject GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_FakeObject);
        }
        public Dictionary<int, FB_FakeObject> GetData()
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
            if (!FB_FakeObjectContainer.FB_FakeObjectContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_FakeObjectContainer.GetRootAsFB_FakeObjectContainer(bb);
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
