using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_CloseUpShotProvider
    {
        private static FB_CloseUpShotProvider _Instance;
        public static FB_CloseUpShotProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_CloseUpShotProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Client/CloseUpShot.txt";
        protected Dictionary<int, FB_CloseUpShot> mData = new Dictionary<int, FB_CloseUpShot>();
        private List<FB_CloseUpShot> mListData = new List<FB_CloseUpShot>();
        public List<FB_CloseUpShot> ListData
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
        public FB_CloseUpShot GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_CloseUpShot);
        }
        public Dictionary<int, FB_CloseUpShot> GetData()
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
            if (!FB_CloseUpShotContainer.FB_CloseUpShotContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_CloseUpShotContainer.GetRootAsFB_CloseUpShotContainer(bb);
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
