using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_MarryBaseInfoProvider
    {
        private static FB_MarryBaseInfoProvider _Instance;
        public static FB_MarryBaseInfoProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_MarryBaseInfoProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/MarryBaseInfo.txt";
        protected Dictionary<int, FB_MarryBaseInfo> mData = new Dictionary<int, FB_MarryBaseInfo>();
        private List<FB_MarryBaseInfo> mListData = new List<FB_MarryBaseInfo>();
        public List<FB_MarryBaseInfo> ListData
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
        public FB_MarryBaseInfo GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_MarryBaseInfo);
        }
        public Dictionary<int, FB_MarryBaseInfo> GetData()
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
            if (!FB_MarryBaseInfoContainer.FB_MarryBaseInfoContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_MarryBaseInfoContainer.GetRootAsFB_MarryBaseInfoContainer(bb);
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
