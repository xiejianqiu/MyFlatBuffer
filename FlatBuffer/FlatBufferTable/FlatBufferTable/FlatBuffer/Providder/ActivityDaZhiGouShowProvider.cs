using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_ActivityDaZhiGouShowProvider
    {
        private static FB_ActivityDaZhiGouShowProvider _Instance;
        public static FB_ActivityDaZhiGouShowProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_ActivityDaZhiGouShowProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Client/ActivityDaZhiGouShow.txt";
        protected Dictionary<int, FB_ActivityDaZhiGouShow> mData = new Dictionary<int, FB_ActivityDaZhiGouShow>();
        private List<FB_ActivityDaZhiGouShow> mListData = new List<FB_ActivityDaZhiGouShow>();
        public List<FB_ActivityDaZhiGouShow> ListData
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
        public FB_ActivityDaZhiGouShow GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_ActivityDaZhiGouShow);
        }
        public Dictionary<int, FB_ActivityDaZhiGouShow> GetData()
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
            if (!FB_ActivityDaZhiGouShowContainer.FB_ActivityDaZhiGouShowContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_ActivityDaZhiGouShowContainer.GetRootAsFB_ActivityDaZhiGouShowContainer(bb);
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
