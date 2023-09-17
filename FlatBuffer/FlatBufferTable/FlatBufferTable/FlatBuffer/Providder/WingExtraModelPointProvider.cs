using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_WingExtraModelPointProvider
    {
        private static FB_WingExtraModelPointProvider _Instance;
        public static FB_WingExtraModelPointProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_WingExtraModelPointProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Client/WingExtraModelPoint.txt";
        protected Dictionary<int, FB_WingExtraModelPoint> mData = new Dictionary<int, FB_WingExtraModelPoint>();
        private List<FB_WingExtraModelPoint> mListData = new List<FB_WingExtraModelPoint>();
        public List<FB_WingExtraModelPoint> ListData
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
        public FB_WingExtraModelPoint GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_WingExtraModelPoint);
        }
        public Dictionary<int, FB_WingExtraModelPoint> GetData()
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
            if (!FB_WingExtraModelPointContainer.FB_WingExtraModelPointContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_WingExtraModelPointContainer.GetRootAsFB_WingExtraModelPointContainer(bb);
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
