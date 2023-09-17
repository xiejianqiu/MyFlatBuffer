using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_ZhuangBeiXunBaoProvider
    {
        private static FB_ZhuangBeiXunBaoProvider _Instance;
        public static FB_ZhuangBeiXunBaoProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_ZhuangBeiXunBaoProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/ZhuangBeiXunBao.txt";
        protected Dictionary<int, FB_ZhuangBeiXunBao> mData = new Dictionary<int, FB_ZhuangBeiXunBao>();
        private List<FB_ZhuangBeiXunBao> mListData = new List<FB_ZhuangBeiXunBao>();
        public List<FB_ZhuangBeiXunBao> ListData
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
        public FB_ZhuangBeiXunBao GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_ZhuangBeiXunBao);
        }
        public Dictionary<int, FB_ZhuangBeiXunBao> GetData()
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
            if (!FB_ZhuangBeiXunBaoContainer.FB_ZhuangBeiXunBaoContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_ZhuangBeiXunBaoContainer.GetRootAsFB_ZhuangBeiXunBaoContainer(bb);
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
