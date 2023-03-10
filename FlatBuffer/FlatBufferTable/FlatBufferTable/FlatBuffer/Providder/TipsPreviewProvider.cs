using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_TipsPreviewProvider
    {
        private static FB_TipsPreviewProvider _Instance;
        public static FB_TipsPreviewProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_TipsPreviewProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Client/TipsPreview.txt";
        protected Dictionary<int, FB_TipsPreview> mData = new Dictionary<int, FB_TipsPreview>();
        private List<FB_TipsPreview> mListData = new List<FB_TipsPreview>();
        public List<FB_TipsPreview> ListData
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
        public FB_TipsPreview GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_TipsPreview);
        }
        public Dictionary<int, FB_TipsPreview> GetData()
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
            if (!FB_TipsPreviewContainer.FB_TipsPreviewContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_TipsPreviewContainer.GetRootAsFB_TipsPreviewContainer(bb);
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
