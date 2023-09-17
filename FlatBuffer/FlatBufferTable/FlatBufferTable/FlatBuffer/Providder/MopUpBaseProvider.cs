using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_MopUpBaseProvider
    {
        private static FB_MopUpBaseProvider _Instance;
        public static FB_MopUpBaseProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_MopUpBaseProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/MopUpBase.txt";
        protected Dictionary<int, FB_MopUpBase> mData = new Dictionary<int, FB_MopUpBase>();
        private List<FB_MopUpBase> mListData = new List<FB_MopUpBase>();
        public List<FB_MopUpBase> ListData
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
        public FB_MopUpBase GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_MopUpBase);
        }
        public Dictionary<int, FB_MopUpBase> GetData()
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
            if (!FB_MopUpBaseContainer.FB_MopUpBaseContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_MopUpBaseContainer.GetRootAsFB_MopUpBaseContainer(bb);
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
