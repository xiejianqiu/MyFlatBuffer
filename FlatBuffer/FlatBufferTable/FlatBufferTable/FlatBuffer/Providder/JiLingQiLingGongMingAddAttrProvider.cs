using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_JiLingQiLingGongMingAddAttrProvider
    {
        private static FB_JiLingQiLingGongMingAddAttrProvider _Instance;
        public static FB_JiLingQiLingGongMingAddAttrProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_JiLingQiLingGongMingAddAttrProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/JiLingQiLingGongMingAddAttr.txt";
        protected Dictionary<int, FB_JiLingQiLingGongMingAddAttr> mData = new Dictionary<int, FB_JiLingQiLingGongMingAddAttr>();
        private List<FB_JiLingQiLingGongMingAddAttr> mListData = new List<FB_JiLingQiLingGongMingAddAttr>();
        public List<FB_JiLingQiLingGongMingAddAttr> ListData
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
        public FB_JiLingQiLingGongMingAddAttr GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_JiLingQiLingGongMingAddAttr);
        }
        public Dictionary<int, FB_JiLingQiLingGongMingAddAttr> GetData()
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
            if (!FB_JiLingQiLingGongMingAddAttrContainer.FB_JiLingQiLingGongMingAddAttrContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_JiLingQiLingGongMingAddAttrContainer.GetRootAsFB_JiLingQiLingGongMingAddAttrContainer(bb);
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
