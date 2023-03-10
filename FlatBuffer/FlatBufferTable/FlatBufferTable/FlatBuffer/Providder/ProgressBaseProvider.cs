using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_ProgressBaseProvider
    {
        private static FB_ProgressBaseProvider _Instance;
        public static FB_ProgressBaseProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_ProgressBaseProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/ProgressBase.txt";
        protected Dictionary<int, FB_ProgressBase> mData = new Dictionary<int, FB_ProgressBase>();
        private List<FB_ProgressBase> mListData = new List<FB_ProgressBase>();
        public List<FB_ProgressBase> ListData
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
        public FB_ProgressBase GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_ProgressBase);
        }
        public Dictionary<int, FB_ProgressBase> GetData()
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
            if (!FB_ProgressBaseContainer.FB_ProgressBaseContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_ProgressBaseContainer.GetRootAsFB_ProgressBaseContainer(bb);
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
