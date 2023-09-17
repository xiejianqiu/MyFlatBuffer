using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_MarryXinWuBaseProvider
    {
        private static FB_MarryXinWuBaseProvider _Instance;
        public static FB_MarryXinWuBaseProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_MarryXinWuBaseProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/MarryXinWuBase.txt";
        protected Dictionary<int, FB_MarryXinWuBase> mData = new Dictionary<int, FB_MarryXinWuBase>();
        private List<FB_MarryXinWuBase> mListData = new List<FB_MarryXinWuBase>();
        public List<FB_MarryXinWuBase> ListData
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
        public FB_MarryXinWuBase GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_MarryXinWuBase);
        }
        public Dictionary<int, FB_MarryXinWuBase> GetData()
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
            if (!FB_MarryXinWuBaseContainer.FB_MarryXinWuBaseContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_MarryXinWuBaseContainer.GetRootAsFB_MarryXinWuBaseContainer(bb);
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
