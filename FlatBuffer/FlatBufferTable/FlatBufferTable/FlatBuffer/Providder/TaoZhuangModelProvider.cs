using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_TaoZhuangModelProvider
    {
        private static FB_TaoZhuangModelProvider _Instance;
        public static FB_TaoZhuangModelProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_TaoZhuangModelProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Client/TaoZhuangModel.txt";
        protected Dictionary<int, FB_TaoZhuangModel> mData = new Dictionary<int, FB_TaoZhuangModel>();
        private List<FB_TaoZhuangModel> mListData = new List<FB_TaoZhuangModel>();
        public List<FB_TaoZhuangModel> ListData
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
        public FB_TaoZhuangModel GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_TaoZhuangModel);
        }
        public Dictionary<int, FB_TaoZhuangModel> GetData()
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
            if (!FB_TaoZhuangModelContainer.FB_TaoZhuangModelContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_TaoZhuangModelContainer.GetRootAsFB_TaoZhuangModelContainer(bb);
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
