using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_ShenYuFengHaoBaseProvider
    {
        private static FB_ShenYuFengHaoBaseProvider _Instance;
        public static FB_ShenYuFengHaoBaseProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_ShenYuFengHaoBaseProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/ShenYuFengHaoBase.txt";
        protected Dictionary<int, FB_ShenYuFengHaoBase> mData = new Dictionary<int, FB_ShenYuFengHaoBase>();
        private List<FB_ShenYuFengHaoBase> mListData = new List<FB_ShenYuFengHaoBase>();
        public List<FB_ShenYuFengHaoBase> ListData
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
        public FB_ShenYuFengHaoBase GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_ShenYuFengHaoBase);
        }
        public Dictionary<int, FB_ShenYuFengHaoBase> GetData()
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
            if (!FB_ShenYuFengHaoBaseContainer.FB_ShenYuFengHaoBaseContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_ShenYuFengHaoBaseContainer.GetRootAsFB_ShenYuFengHaoBaseContainer(bb);
            for (int index = 0; index < data.ItemsLength; index++)
            {
                var item = data.GetItems(index);
                mData.Add(item.SceneID, item);
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
