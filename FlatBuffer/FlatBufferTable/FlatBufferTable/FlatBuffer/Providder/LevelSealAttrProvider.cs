using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_LevelSealAttrProvider
    {
        private static FB_LevelSealAttrProvider _Instance;
        public static FB_LevelSealAttrProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_LevelSealAttrProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/LevelSealAttr.txt";
        protected Dictionary<int, FB_LevelSealAttr> mData = new Dictionary<int, FB_LevelSealAttr>();
        private List<FB_LevelSealAttr> mListData = new List<FB_LevelSealAttr>();
        public List<FB_LevelSealAttr> ListData
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
        public FB_LevelSealAttr GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_LevelSealAttr);
        }
        public Dictionary<int, FB_LevelSealAttr> GetData()
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
            if (!FB_LevelSealAttrContainer.FB_LevelSealAttrContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_LevelSealAttrContainer.GetRootAsFB_LevelSealAttrContainer(bb);
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
