using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_TimingBoxProvider
    {
        private static FB_TimingBoxProvider _Instance;
        public static FB_TimingBoxProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_TimingBoxProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/TimingBox.txt";
        protected Dictionary<int, FB_TimingBox> mData = new Dictionary<int, FB_TimingBox>();
        private List<FB_TimingBox> mListData = new List<FB_TimingBox>();
        public List<FB_TimingBox> ListData
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
        public FB_TimingBox GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_TimingBox);
        }
        public Dictionary<int, FB_TimingBox> GetData()
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
            if (!FB_TimingBoxContainer.FB_TimingBoxContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_TimingBoxContainer.GetRootAsFB_TimingBoxContainer(bb);
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
