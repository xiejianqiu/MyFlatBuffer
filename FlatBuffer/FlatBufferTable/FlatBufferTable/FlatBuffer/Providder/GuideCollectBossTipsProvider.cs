using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_GuideCollectBossTipsProvider
    {
        private static FB_GuideCollectBossTipsProvider _Instance;
        public static FB_GuideCollectBossTipsProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_GuideCollectBossTipsProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/GuideCollectBossTips.txt";
        protected Dictionary<int, FB_GuideCollectBossTips> mData = new Dictionary<int, FB_GuideCollectBossTips>();
        private List<FB_GuideCollectBossTips> mListData = new List<FB_GuideCollectBossTips>();
        public List<FB_GuideCollectBossTips> ListData
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
        public FB_GuideCollectBossTips GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_GuideCollectBossTips);
        }
        public Dictionary<int, FB_GuideCollectBossTips> GetData()
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
            if (!FB_GuideCollectBossTipsContainer.FB_GuideCollectBossTipsContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_GuideCollectBossTipsContainer.GetRootAsFB_GuideCollectBossTipsContainer(bb);
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
