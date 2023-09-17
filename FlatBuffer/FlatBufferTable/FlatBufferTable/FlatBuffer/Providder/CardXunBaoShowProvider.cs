using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_CardXunBaoShowProvider
    {
        private static FB_CardXunBaoShowProvider _Instance;
        public static FB_CardXunBaoShowProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_CardXunBaoShowProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/CardXunBaoShow.txt";
        protected Dictionary<int, FB_CardXunBaoShow> mData = new Dictionary<int, FB_CardXunBaoShow>();
        private List<FB_CardXunBaoShow> mListData = new List<FB_CardXunBaoShow>();
        public List<FB_CardXunBaoShow> ListData
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
        public FB_CardXunBaoShow GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_CardXunBaoShow);
        }
        public Dictionary<int, FB_CardXunBaoShow> GetData()
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
            if (!FB_CardXunBaoShowContainer.FB_CardXunBaoShowContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_CardXunBaoShowContainer.GetRootAsFB_CardXunBaoShowContainer(bb);
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
