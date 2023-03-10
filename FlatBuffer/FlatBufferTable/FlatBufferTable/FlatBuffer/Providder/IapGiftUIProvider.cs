using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_IapGiftUIProvider
    {
        private static FB_IapGiftUIProvider _Instance;
        public static FB_IapGiftUIProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_IapGiftUIProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Client/IapGiftUI.txt";
        protected Dictionary<int, FB_IapGiftUI> mData = new Dictionary<int, FB_IapGiftUI>();
        private List<FB_IapGiftUI> mListData = new List<FB_IapGiftUI>();
        public List<FB_IapGiftUI> ListData
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
        public FB_IapGiftUI GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_IapGiftUI);
        }
        public Dictionary<int, FB_IapGiftUI> GetData()
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
            if (!FB_IapGiftUIContainer.FB_IapGiftUIContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_IapGiftUIContainer.GetRootAsFB_IapGiftUIContainer(bb);
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
