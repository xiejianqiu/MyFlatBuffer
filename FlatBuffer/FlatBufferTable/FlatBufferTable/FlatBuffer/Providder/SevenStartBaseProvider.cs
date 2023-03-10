using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_SevenStartBaseProvider
    {
        private static FB_SevenStartBaseProvider _Instance;
        public static FB_SevenStartBaseProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_SevenStartBaseProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/SevenStartBase.txt";
        protected Dictionary<int, FB_SevenStartBase> mData = new Dictionary<int, FB_SevenStartBase>();
        private List<FB_SevenStartBase> mListData = new List<FB_SevenStartBase>();
        public List<FB_SevenStartBase> ListData
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
        public FB_SevenStartBase GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_SevenStartBase);
        }
        public Dictionary<int, FB_SevenStartBase> GetData()
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
            if (!FB_SevenStartBaseContainer.FB_SevenStartBaseContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_SevenStartBaseContainer.GetRootAsFB_SevenStartBaseContainer(bb);
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
