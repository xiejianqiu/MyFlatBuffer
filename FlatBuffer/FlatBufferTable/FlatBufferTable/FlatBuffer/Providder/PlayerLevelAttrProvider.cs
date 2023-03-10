using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_PlayerLevelAttrProvider
    {
        private static FB_PlayerLevelAttrProvider _Instance;
        public static FB_PlayerLevelAttrProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_PlayerLevelAttrProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/PlayerLevelAttr.txt";
        protected Dictionary<int, FB_PlayerLevelAttr> mData = new Dictionary<int, FB_PlayerLevelAttr>();
        private List<FB_PlayerLevelAttr> mListData = new List<FB_PlayerLevelAttr>();
        public List<FB_PlayerLevelAttr> ListData
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
        public FB_PlayerLevelAttr GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_PlayerLevelAttr);
        }
        public Dictionary<int, FB_PlayerLevelAttr> GetData()
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
            if (!FB_PlayerLevelAttrContainer.FB_PlayerLevelAttrContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_PlayerLevelAttrContainer.GetRootAsFB_PlayerLevelAttrContainer(bb);
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