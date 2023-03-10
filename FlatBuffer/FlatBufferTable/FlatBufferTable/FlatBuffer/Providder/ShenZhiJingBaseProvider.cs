using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_ShenZhiJingBaseProvider
    {
        private static FB_ShenZhiJingBaseProvider _Instance;
        public static FB_ShenZhiJingBaseProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_ShenZhiJingBaseProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/ShenZhiJingBase.txt";
        protected Dictionary<int, FB_ShenZhiJingBase> mData = new Dictionary<int, FB_ShenZhiJingBase>();
        private List<FB_ShenZhiJingBase> mListData = new List<FB_ShenZhiJingBase>();
        public List<FB_ShenZhiJingBase> ListData
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
        public FB_ShenZhiJingBase GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_ShenZhiJingBase);
        }
        public Dictionary<int, FB_ShenZhiJingBase> GetData()
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
            if (!FB_ShenZhiJingBaseContainer.FB_ShenZhiJingBaseContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_ShenZhiJingBaseContainer.GetRootAsFB_ShenZhiJingBaseContainer(bb);
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