using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_HuanLeXunBaoProvider
    {
        private static FB_HuanLeXunBaoProvider _Instance;
        public static FB_HuanLeXunBaoProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_HuanLeXunBaoProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Client/HuanLeXunBao.txt";
        protected Dictionary<int, FB_HuanLeXunBao> mData = new Dictionary<int, FB_HuanLeXunBao>();
        private List<FB_HuanLeXunBao> mListData = new List<FB_HuanLeXunBao>();
        public List<FB_HuanLeXunBao> ListData
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
        public FB_HuanLeXunBao GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_HuanLeXunBao);
        }
        public Dictionary<int, FB_HuanLeXunBao> GetData()
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
            if (!FB_HuanLeXunBaoContainer.FB_HuanLeXunBaoContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_HuanLeXunBaoContainer.GetRootAsFB_HuanLeXunBaoContainer(bb);
            for (int index = 0; index < data.ItemsLength; index++)
            {
                var item = data.GetItems(index);
                mData.Add(item.ModelTypeId, item);
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
