using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_AutoBindBaseProvider
    {
        private static FB_AutoBindBaseProvider _Instance;
        public static FB_AutoBindBaseProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_AutoBindBaseProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/AutoBindBase.txt";
        protected Dictionary<int, FB_AutoBindBase> mData = new Dictionary<int, FB_AutoBindBase>();
        private List<FB_AutoBindBase> mListData = new List<FB_AutoBindBase>();
        public List<FB_AutoBindBase> ListData
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
        public FB_AutoBindBase GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_AutoBindBase);
        }
        public Dictionary<int, FB_AutoBindBase> GetData()
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
            if (!FB_AutoBindBaseContainer.FB_AutoBindBaseContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_AutoBindBaseContainer.GetRootAsFB_AutoBindBaseContainer(bb);
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
