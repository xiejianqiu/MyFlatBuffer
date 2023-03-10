using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_OccupationBaseProvider
    {
        private static FB_OccupationBaseProvider _Instance;
        public static FB_OccupationBaseProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_OccupationBaseProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/OccupationBase.txt";
        protected Dictionary<int, FB_OccupationBase> mData = new Dictionary<int, FB_OccupationBase>();
        private List<FB_OccupationBase> mListData = new List<FB_OccupationBase>();
        public List<FB_OccupationBase> ListData
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
        public FB_OccupationBase GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_OccupationBase);
        }
        public Dictionary<int, FB_OccupationBase> GetData()
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
            if (!FB_OccupationBaseContainer.FB_OccupationBaseContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_OccupationBaseContainer.GetRootAsFB_OccupationBaseContainer(bb);
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
