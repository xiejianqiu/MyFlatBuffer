using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_RuneAttrProvider
    {
        private static FB_RuneAttrProvider _Instance;
        public static FB_RuneAttrProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_RuneAttrProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/RuneAttr.txt";
        protected Dictionary<int, FB_RuneAttr> mData = new Dictionary<int, FB_RuneAttr>();
        private List<FB_RuneAttr> mListData = new List<FB_RuneAttr>();
        public List<FB_RuneAttr> ListData
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
        public FB_RuneAttr GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_RuneAttr);
        }
        public Dictionary<int, FB_RuneAttr> GetData()
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
            if (!FB_RuneAttrContainer.FB_RuneAttrContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_RuneAttrContainer.GetRootAsFB_RuneAttrContainer(bb);
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
