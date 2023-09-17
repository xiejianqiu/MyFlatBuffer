using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_UITextProvider
    {
        private static FB_UITextProvider _Instance;
        public static FB_UITextProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_UITextProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Client/UIText.txt";
        protected Dictionary<int, FB_UIText> mData = new Dictionary<int, FB_UIText>();
        private List<FB_UIText> mListData = new List<FB_UIText>();
        public List<FB_UIText> ListData
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
        public FB_UIText GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_UIText);
        }
        public Dictionary<int, FB_UIText> GetData()
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
            if (!FB_UITextContainer.FB_UITextContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_UITextContainer.GetRootAsFB_UITextContainer(bb);
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
