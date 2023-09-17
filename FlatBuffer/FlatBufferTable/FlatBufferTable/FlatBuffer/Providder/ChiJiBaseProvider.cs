using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_ChiJiBaseProvider
    {
        private static FB_ChiJiBaseProvider _Instance;
        public static FB_ChiJiBaseProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_ChiJiBaseProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/ChiJiBase.txt";
        protected Dictionary<int, FB_ChiJiBase> mData = new Dictionary<int, FB_ChiJiBase>();
        private List<FB_ChiJiBase> mListData = new List<FB_ChiJiBase>();
        public List<FB_ChiJiBase> ListData
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
        public FB_ChiJiBase GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_ChiJiBase);
        }
        public Dictionary<int, FB_ChiJiBase> GetData()
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
            if (!FB_ChiJiBaseContainer.FB_ChiJiBaseContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_ChiJiBaseContainer.GetRootAsFB_ChiJiBaseContainer(bb);
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
