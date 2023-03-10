using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_OldGodSuitAttrProvider
    {
        private static FB_OldGodSuitAttrProvider _Instance;
        public static FB_OldGodSuitAttrProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_OldGodSuitAttrProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/OldGodSuitAttr.txt";
        protected Dictionary<int, FB_OldGodSuitAttr> mData = new Dictionary<int, FB_OldGodSuitAttr>();
        private List<FB_OldGodSuitAttr> mListData = new List<FB_OldGodSuitAttr>();
        public List<FB_OldGodSuitAttr> ListData
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
        public FB_OldGodSuitAttr GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_OldGodSuitAttr);
        }
        public Dictionary<int, FB_OldGodSuitAttr> GetData()
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
            if (!FB_OldGodSuitAttrContainer.FB_OldGodSuitAttrContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_OldGodSuitAttrContainer.GetRootAsFB_OldGodSuitAttrContainer(bb);
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
