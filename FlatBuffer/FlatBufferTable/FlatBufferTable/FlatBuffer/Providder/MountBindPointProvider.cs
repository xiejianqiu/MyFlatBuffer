using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_MountBindPointProvider
    {
        private static FB_MountBindPointProvider _Instance;
        public static FB_MountBindPointProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_MountBindPointProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Client/MountBindPoint.txt";
        protected Dictionary<int, FB_MountBindPoint> mData = new Dictionary<int, FB_MountBindPoint>();
        private List<FB_MountBindPoint> mListData = new List<FB_MountBindPoint>();
        public List<FB_MountBindPoint> ListData
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
        public FB_MountBindPoint GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_MountBindPoint);
        }
        public Dictionary<int, FB_MountBindPoint> GetData()
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
            if (!FB_MountBindPointContainer.FB_MountBindPointContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_MountBindPointContainer.GetRootAsFB_MountBindPointContainer(bb);
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
