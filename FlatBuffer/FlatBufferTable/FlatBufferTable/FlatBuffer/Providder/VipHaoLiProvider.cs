using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_VipHaoLiProvider
    {
        private static FB_VipHaoLiProvider _Instance;
        public static FB_VipHaoLiProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_VipHaoLiProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/VipHaoLi.txt";
        protected Dictionary<int, FB_VipHaoLi> mData = new Dictionary<int, FB_VipHaoLi>();
        private List<FB_VipHaoLi> mListData = new List<FB_VipHaoLi>();
        public List<FB_VipHaoLi> ListData
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
        public FB_VipHaoLi GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_VipHaoLi);
        }
        public Dictionary<int, FB_VipHaoLi> GetData()
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
            if (!FB_VipHaoLiContainer.FB_VipHaoLiContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_VipHaoLiContainer.GetRootAsFB_VipHaoLiContainer(bb);
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
