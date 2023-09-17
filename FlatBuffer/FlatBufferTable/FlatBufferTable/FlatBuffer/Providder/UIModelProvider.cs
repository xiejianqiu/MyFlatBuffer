using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_UIModelProvider
    {
        private static FB_UIModelProvider _Instance;
        public static FB_UIModelProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_UIModelProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Client/UIModel.txt";
        protected Dictionary<int, FB_UIModel> mData = new Dictionary<int, FB_UIModel>();
        private List<FB_UIModel> mListData = new List<FB_UIModel>();
        public List<FB_UIModel> ListData
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
        public FB_UIModel GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_UIModel);
        }
        public Dictionary<int, FB_UIModel> GetData()
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
            if (!FB_UIModelContainer.FB_UIModelContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_UIModelContainer.GetRootAsFB_UIModelContainer(bb);
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
