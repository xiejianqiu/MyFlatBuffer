using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_JiYiCardProvider
    {
        private static FB_JiYiCardProvider _Instance;
        public static FB_JiYiCardProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_JiYiCardProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Client/JiYiCard.txt";
        protected Dictionary<int, FB_JiYiCard> mData = new Dictionary<int, FB_JiYiCard>();
        private List<FB_JiYiCard> mListData = new List<FB_JiYiCard>();
        public List<FB_JiYiCard> ListData
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
        public FB_JiYiCard GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_JiYiCard);
        }
        public Dictionary<int, FB_JiYiCard> GetData()
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
            if (!FB_JiYiCardContainer.FB_JiYiCardContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_JiYiCardContainer.GetRootAsFB_JiYiCardContainer(bb);
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
