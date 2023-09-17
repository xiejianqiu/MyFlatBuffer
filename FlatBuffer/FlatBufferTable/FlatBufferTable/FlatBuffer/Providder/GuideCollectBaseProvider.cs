using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_GuideCollectBaseProvider
    {
        private static FB_GuideCollectBaseProvider _Instance;
        public static FB_GuideCollectBaseProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_GuideCollectBaseProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/GuideCollectBase.txt";
        protected Dictionary<int, FB_GuideCollectBase> mData = new Dictionary<int, FB_GuideCollectBase>();
        private List<FB_GuideCollectBase> mListData = new List<FB_GuideCollectBase>();
        public List<FB_GuideCollectBase> ListData
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
        public FB_GuideCollectBase GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_GuideCollectBase);
        }
        public Dictionary<int, FB_GuideCollectBase> GetData()
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
            if (!FB_GuideCollectBaseContainer.FB_GuideCollectBaseContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_GuideCollectBaseContainer.GetRootAsFB_GuideCollectBaseContainer(bb);
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
