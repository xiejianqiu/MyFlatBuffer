using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_CopySceneLastShotProvider
    {
        private static FB_CopySceneLastShotProvider _Instance;
        public static FB_CopySceneLastShotProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_CopySceneLastShotProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Client/CopySceneLastShot.txt";
        protected Dictionary<int, FB_CopySceneLastShot> mData = new Dictionary<int, FB_CopySceneLastShot>();
        private List<FB_CopySceneLastShot> mListData = new List<FB_CopySceneLastShot>();
        public List<FB_CopySceneLastShot> ListData
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
        public FB_CopySceneLastShot GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_CopySceneLastShot);
        }
        public Dictionary<int, FB_CopySceneLastShot> GetData()
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
            if (!FB_CopySceneLastShotContainer.FB_CopySceneLastShotContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_CopySceneLastShotContainer.GetRootAsFB_CopySceneLastShotContainer(bb);
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
