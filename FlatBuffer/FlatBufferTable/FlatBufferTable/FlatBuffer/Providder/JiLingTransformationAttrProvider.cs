using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_JiLingTransformationAttrProvider
    {
        private static FB_JiLingTransformationAttrProvider _Instance;
        public static FB_JiLingTransformationAttrProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_JiLingTransformationAttrProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/JiLingTransformationAttr.txt";
        protected Dictionary<int, FB_JiLingTransformationAttr> mData = new Dictionary<int, FB_JiLingTransformationAttr>();
        private List<FB_JiLingTransformationAttr> mListData = new List<FB_JiLingTransformationAttr>();
        public List<FB_JiLingTransformationAttr> ListData
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
        public FB_JiLingTransformationAttr GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_JiLingTransformationAttr);
        }
        public Dictionary<int, FB_JiLingTransformationAttr> GetData()
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
            if (!FB_JiLingTransformationAttrContainer.FB_JiLingTransformationAttrContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_JiLingTransformationAttrContainer.GetRootAsFB_JiLingTransformationAttrContainer(bb);
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
