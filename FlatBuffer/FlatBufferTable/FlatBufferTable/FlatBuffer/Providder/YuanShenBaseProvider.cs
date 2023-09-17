using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_YuanShenBaseProvider
    {
        private static FB_YuanShenBaseProvider _Instance;
        public static FB_YuanShenBaseProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_YuanShenBaseProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/YuanShenBase.txt";
        protected Dictionary<int, FB_YuanShenBase> mData = new Dictionary<int, FB_YuanShenBase>();
        private List<FB_YuanShenBase> mListData = new List<FB_YuanShenBase>();
        public List<FB_YuanShenBase> ListData
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
        public FB_YuanShenBase GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_YuanShenBase);
        }
        public Dictionary<int, FB_YuanShenBase> GetData()
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
            if (!FB_YuanShenBaseContainer.FB_YuanShenBaseContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_YuanShenBaseContainer.GetRootAsFB_YuanShenBaseContainer(bb);
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
