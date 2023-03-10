using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_GetPathBaseProvider
    {
        private static FB_GetPathBaseProvider _Instance;
        public static FB_GetPathBaseProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_GetPathBaseProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Client/GetPathBase.txt";
        protected Dictionary<int, FB_GetPathBase> mData = new Dictionary<int, FB_GetPathBase>();
        private List<FB_GetPathBase> mListData = new List<FB_GetPathBase>();
        public List<FB_GetPathBase> ListData
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
        public FB_GetPathBase GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_GetPathBase);
        }
        public Dictionary<int, FB_GetPathBase> GetData()
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
            if (!FB_GetPathBaseContainer.FB_GetPathBaseContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_GetPathBaseContainer.GetRootAsFB_GetPathBaseContainer(bb);
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
