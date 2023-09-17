using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_HairModelProvider
    {
        private static FB_HairModelProvider _Instance;
        public static FB_HairModelProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_HairModelProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Client/HairModel.txt";
        protected Dictionary<int, FB_HairModel> mData = new Dictionary<int, FB_HairModel>();
        private List<FB_HairModel> mListData = new List<FB_HairModel>();
        public List<FB_HairModel> ListData
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
        public FB_HairModel GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_HairModel);
        }
        public Dictionary<int, FB_HairModel> GetData()
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
            if (!FB_HairModelContainer.FB_HairModelContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_HairModelContainer.GetRootAsFB_HairModelContainer(bb);
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
