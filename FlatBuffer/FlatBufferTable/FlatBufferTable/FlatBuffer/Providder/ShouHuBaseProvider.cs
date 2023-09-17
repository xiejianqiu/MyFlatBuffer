using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_ShouHuBaseProvider
    {
        private static FB_ShouHuBaseProvider _Instance;
        public static FB_ShouHuBaseProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_ShouHuBaseProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/ShouHuBase.txt";
        protected Dictionary<int, FB_ShouHuBase> mData = new Dictionary<int, FB_ShouHuBase>();
        private List<FB_ShouHuBase> mListData = new List<FB_ShouHuBase>();
        public List<FB_ShouHuBase> ListData
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
        public FB_ShouHuBase GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_ShouHuBase);
        }
        public Dictionary<int, FB_ShouHuBase> GetData()
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
            if (!FB_ShouHuBaseContainer.FB_ShouHuBaseContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_ShouHuBaseContainer.GetRootAsFB_ShouHuBaseContainer(bb);
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
