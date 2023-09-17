using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_SceneGroupPointProvider
    {
        private static FB_SceneGroupPointProvider _Instance;
        public static FB_SceneGroupPointProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_SceneGroupPointProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/SceneGroupPoint.txt";
        protected Dictionary<int, FB_SceneGroupPoint> mData = new Dictionary<int, FB_SceneGroupPoint>();
        private List<FB_SceneGroupPoint> mListData = new List<FB_SceneGroupPoint>();
        public List<FB_SceneGroupPoint> ListData
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
        public FB_SceneGroupPoint GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_SceneGroupPoint);
        }
        public Dictionary<int, FB_SceneGroupPoint> GetData()
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
            if (!FB_SceneGroupPointContainer.FB_SceneGroupPointContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_SceneGroupPointContainer.GetRootAsFB_SceneGroupPointContainer(bb);
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
