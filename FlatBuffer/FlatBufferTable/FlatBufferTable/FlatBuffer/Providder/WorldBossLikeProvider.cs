using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_WorldBossLikeProvider
    {
        private static FB_WorldBossLikeProvider _Instance;
        public static FB_WorldBossLikeProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_WorldBossLikeProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/WorldBossLike.txt";
        protected Dictionary<int, FB_WorldBossLike> mData = new Dictionary<int, FB_WorldBossLike>();
        private List<FB_WorldBossLike> mListData = new List<FB_WorldBossLike>();
        public List<FB_WorldBossLike> ListData
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
        public FB_WorldBossLike GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_WorldBossLike);
        }
        public Dictionary<int, FB_WorldBossLike> GetData()
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
            if (!FB_WorldBossLikeContainer.FB_WorldBossLikeContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_WorldBossLikeContainer.GetRootAsFB_WorldBossLikeContainer(bb);
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