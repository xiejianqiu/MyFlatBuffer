using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_TaoZhuangAttrProvider
    {
        private static FB_TaoZhuangAttrProvider _Instance;
        public static FB_TaoZhuangAttrProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_TaoZhuangAttrProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/TaoZhuangAttr.txt";
        protected Dictionary<int, FB_TaoZhuangAttr> mData = new Dictionary<int, FB_TaoZhuangAttr>();
        private List<FB_TaoZhuangAttr> mListData = new List<FB_TaoZhuangAttr>();
        public List<FB_TaoZhuangAttr> ListData
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
        public FB_TaoZhuangAttr GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_TaoZhuangAttr);
        }
        public Dictionary<int, FB_TaoZhuangAttr> GetData()
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
            if (!FB_TaoZhuangAttrContainer.FB_TaoZhuangAttrContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_TaoZhuangAttrContainer.GetRootAsFB_TaoZhuangAttrContainer(bb);
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