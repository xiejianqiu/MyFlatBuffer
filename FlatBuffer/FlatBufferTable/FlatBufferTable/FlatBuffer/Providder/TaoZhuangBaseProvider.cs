using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_TaoZhuangBaseProvider
    {
        private static FB_TaoZhuangBaseProvider _Instance;
        public static FB_TaoZhuangBaseProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_TaoZhuangBaseProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/TaoZhuangBase.txt";
        protected Dictionary<int, FB_TaoZhuangBase> mData = new Dictionary<int, FB_TaoZhuangBase>();
        private List<FB_TaoZhuangBase> mListData = new List<FB_TaoZhuangBase>();
        public List<FB_TaoZhuangBase> ListData
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
        public FB_TaoZhuangBase GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_TaoZhuangBase);
        }
        public Dictionary<int, FB_TaoZhuangBase> GetData()
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
            if (!FB_TaoZhuangBaseContainer.FB_TaoZhuangBaseContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_TaoZhuangBaseContainer.GetRootAsFB_TaoZhuangBaseContainer(bb);
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
