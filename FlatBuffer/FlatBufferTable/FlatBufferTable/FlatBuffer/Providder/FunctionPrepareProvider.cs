using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_FunctionPrepareProvider
    {
        private static FB_FunctionPrepareProvider _Instance;
        public static FB_FunctionPrepareProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_FunctionPrepareProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/FunctionPrepare.txt";
        protected Dictionary<int, FB_FunctionPrepare> mData = new Dictionary<int, FB_FunctionPrepare>();
        private List<FB_FunctionPrepare> mListData = new List<FB_FunctionPrepare>();
        public List<FB_FunctionPrepare> ListData
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
        public FB_FunctionPrepare GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_FunctionPrepare);
        }
        public Dictionary<int, FB_FunctionPrepare> GetData()
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
            if (!FB_FunctionPrepareContainer.FB_FunctionPrepareContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_FunctionPrepareContainer.GetRootAsFB_FunctionPrepareContainer(bb);
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
