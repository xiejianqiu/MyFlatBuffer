using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_ActivityAncientSealSearchProvider
    {
        private static FB_ActivityAncientSealSearchProvider _Instance;
        public static FB_ActivityAncientSealSearchProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_ActivityAncientSealSearchProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/ActivityAncientSealSearch.txt";
        protected Dictionary<int, FB_ActivityAncientSealSearch> mData = new Dictionary<int, FB_ActivityAncientSealSearch>();
        private List<FB_ActivityAncientSealSearch> mListData = new List<FB_ActivityAncientSealSearch>();
        public List<FB_ActivityAncientSealSearch> ListData
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
        public FB_ActivityAncientSealSearch GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_ActivityAncientSealSearch);
        }
        public Dictionary<int, FB_ActivityAncientSealSearch> GetData()
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
            if (!FB_ActivityAncientSealSearchContainer.FB_ActivityAncientSealSearchContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_ActivityAncientSealSearchContainer.GetRootAsFB_ActivityAncientSealSearchContainer(bb);
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
