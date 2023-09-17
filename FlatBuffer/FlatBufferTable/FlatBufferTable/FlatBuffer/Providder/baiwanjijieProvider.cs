using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_baiwanjijieProvider
    {
        private static FB_baiwanjijieProvider _Instance;
        public static FB_baiwanjijieProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_baiwanjijieProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/baiwanjijie.txt";
        protected Dictionary<int, FB_baiwanjijie> mData = new Dictionary<int, FB_baiwanjijie>();
        private List<FB_baiwanjijie> mListData = new List<FB_baiwanjijie>();
        public List<FB_baiwanjijie> ListData
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
        public FB_baiwanjijie GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_baiwanjijie);
        }
        public Dictionary<int, FB_baiwanjijie> GetData()
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
            if (!FB_baiwanjijieContainer.FB_baiwanjijieContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_baiwanjijieContainer.GetRootAsFB_baiwanjijieContainer(bb);
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
