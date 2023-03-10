using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_TeamPlatformProvider
    {
        private static FB_TeamPlatformProvider _Instance;
        public static FB_TeamPlatformProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_TeamPlatformProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/TeamPlatform.txt";
        protected Dictionary<int, FB_TeamPlatform> mData = new Dictionary<int, FB_TeamPlatform>();
        private List<FB_TeamPlatform> mListData = new List<FB_TeamPlatform>();
        public List<FB_TeamPlatform> ListData
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
        public FB_TeamPlatform GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_TeamPlatform);
        }
        public Dictionary<int, FB_TeamPlatform> GetData()
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
            if (!FB_TeamPlatformContainer.FB_TeamPlatformContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_TeamPlatformContainer.GetRootAsFB_TeamPlatformContainer(bb);
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
