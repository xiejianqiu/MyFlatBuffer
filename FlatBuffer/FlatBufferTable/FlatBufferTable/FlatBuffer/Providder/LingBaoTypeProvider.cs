using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_LingBaoTypeProvider
    {
        private static FB_LingBaoTypeProvider _Instance;
        public static FB_LingBaoTypeProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_LingBaoTypeProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Client/LingBaoType.txt";
        protected Dictionary<int, FB_LingBaoType> mData = new Dictionary<int, FB_LingBaoType>();
        private List<FB_LingBaoType> mListData = new List<FB_LingBaoType>();
        public List<FB_LingBaoType> ListData
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
        public FB_LingBaoType GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_LingBaoType);
        }
        public Dictionary<int, FB_LingBaoType> GetData()
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
            if (!FB_LingBaoTypeContainer.FB_LingBaoTypeContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_LingBaoTypeContainer.GetRootAsFB_LingBaoTypeContainer(bb);
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
