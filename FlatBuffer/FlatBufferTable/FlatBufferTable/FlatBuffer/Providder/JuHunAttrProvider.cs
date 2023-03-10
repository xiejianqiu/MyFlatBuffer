using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_JuHunAttrProvider
    {
        private static FB_JuHunAttrProvider _Instance;
        public static FB_JuHunAttrProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_JuHunAttrProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/JuHunAttr.txt";
        protected Dictionary<int, FB_JuHunAttr> mData = new Dictionary<int, FB_JuHunAttr>();
        private List<FB_JuHunAttr> mListData = new List<FB_JuHunAttr>();
        public List<FB_JuHunAttr> ListData
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
        public FB_JuHunAttr GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_JuHunAttr);
        }
        public Dictionary<int, FB_JuHunAttr> GetData()
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
            if (!FB_JuHunAttrContainer.FB_JuHunAttrContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_JuHunAttrContainer.GetRootAsFB_JuHunAttrContainer(bb);
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
