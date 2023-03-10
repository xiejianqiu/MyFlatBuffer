using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_GodWordBaseProvider
    {
        private static FB_GodWordBaseProvider _Instance;
        public static FB_GodWordBaseProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_GodWordBaseProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/GodWordBase.txt";
        protected Dictionary<int, FB_GodWordBase> mData = new Dictionary<int, FB_GodWordBase>();
        private List<FB_GodWordBase> mListData = new List<FB_GodWordBase>();
        public List<FB_GodWordBase> ListData
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
        public FB_GodWordBase GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_GodWordBase);
        }
        public Dictionary<int, FB_GodWordBase> GetData()
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
            if (!FB_GodWordBaseContainer.FB_GodWordBaseContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_GodWordBaseContainer.GetRootAsFB_GodWordBaseContainer(bb);
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