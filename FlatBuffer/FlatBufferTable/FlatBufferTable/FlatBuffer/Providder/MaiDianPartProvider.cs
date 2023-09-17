using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_MaiDianPartProvider
    {
        private static FB_MaiDianPartProvider _Instance;
        public static FB_MaiDianPartProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_MaiDianPartProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/MaiDianPart.txt";
        protected Dictionary<int, FB_MaiDianPart> mData = new Dictionary<int, FB_MaiDianPart>();
        private List<FB_MaiDianPart> mListData = new List<FB_MaiDianPart>();
        public List<FB_MaiDianPart> ListData
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
        public FB_MaiDianPart GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_MaiDianPart);
        }
        public Dictionary<int, FB_MaiDianPart> GetData()
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
            if (!FB_MaiDianPartContainer.FB_MaiDianPartContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_MaiDianPartContainer.GetRootAsFB_MaiDianPartContainer(bb);
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
