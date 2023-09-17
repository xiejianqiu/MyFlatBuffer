using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_MarrySceneInfoProvider
    {
        private static FB_MarrySceneInfoProvider _Instance;
        public static FB_MarrySceneInfoProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_MarrySceneInfoProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/MarrySceneInfo.txt";
        protected Dictionary<int, FB_MarrySceneInfo> mData = new Dictionary<int, FB_MarrySceneInfo>();
        private List<FB_MarrySceneInfo> mListData = new List<FB_MarrySceneInfo>();
        public List<FB_MarrySceneInfo> ListData
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
        public FB_MarrySceneInfo GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_MarrySceneInfo);
        }
        public Dictionary<int, FB_MarrySceneInfo> GetData()
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
            if (!FB_MarrySceneInfoContainer.FB_MarrySceneInfoContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_MarrySceneInfoContainer.GetRootAsFB_MarrySceneInfoContainer(bb);
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
