using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_UIInfoProvider
    {
        private static FB_UIInfoProvider _Instance;
        public static FB_UIInfoProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_UIInfoProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Client/UIInfo.txt";
        protected Dictionary<int, FB_UIInfo> mData = new Dictionary<int, FB_UIInfo>();
        private List<FB_UIInfo> mListData = new List<FB_UIInfo>();
        public List<FB_UIInfo> ListData
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
        public FB_UIInfo GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_UIInfo);
        }
        public Dictionary<int, FB_UIInfo> GetData()
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
            if (!FB_UIInfoContainer.FB_UIInfoContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_UIInfoContainer.GetRootAsFB_UIInfoContainer(bb);
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
