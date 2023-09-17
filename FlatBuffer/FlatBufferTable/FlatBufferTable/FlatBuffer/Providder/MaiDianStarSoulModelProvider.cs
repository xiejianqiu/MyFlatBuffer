using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_MaiDianStarSoulModelProvider
    {
        private static FB_MaiDianStarSoulModelProvider _Instance;
        public static FB_MaiDianStarSoulModelProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_MaiDianStarSoulModelProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Client/MaiDianStarSoulModel.txt";
        protected Dictionary<int, FB_MaiDianStarSoulModel> mData = new Dictionary<int, FB_MaiDianStarSoulModel>();
        private List<FB_MaiDianStarSoulModel> mListData = new List<FB_MaiDianStarSoulModel>();
        public List<FB_MaiDianStarSoulModel> ListData
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
        public FB_MaiDianStarSoulModel GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_MaiDianStarSoulModel);
        }
        public Dictionary<int, FB_MaiDianStarSoulModel> GetData()
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
            if (!FB_MaiDianStarSoulModelContainer.FB_MaiDianStarSoulModelContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_MaiDianStarSoulModelContainer.GetRootAsFB_MaiDianStarSoulModelContainer(bb);
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
