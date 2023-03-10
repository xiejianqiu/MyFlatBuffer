using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_StrLoadingProvider
    {
        private static FB_StrLoadingProvider _Instance;
        public static FB_StrLoadingProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_StrLoadingProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Client/StrLoading.txt";
        protected Dictionary<int, FB_StrLoading> mData = new Dictionary<int, FB_StrLoading>();
        private List<FB_StrLoading> mListData = new List<FB_StrLoading>();
        public List<FB_StrLoading> ListData
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
        public FB_StrLoading GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_StrLoading);
        }
        public Dictionary<int, FB_StrLoading> GetData()
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
            if (!FB_StrLoadingContainer.FB_StrLoadingContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_StrLoadingContainer.GetRootAsFB_StrLoadingContainer(bb);
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
