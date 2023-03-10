using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_MergeTouZiProvider
    {
        private static FB_MergeTouZiProvider _Instance;
        public static FB_MergeTouZiProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_MergeTouZiProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/MergeTouZi.txt";
        protected Dictionary<int, FB_MergeTouZi> mData = new Dictionary<int, FB_MergeTouZi>();
        private List<FB_MergeTouZi> mListData = new List<FB_MergeTouZi>();
        public List<FB_MergeTouZi> ListData
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
        public FB_MergeTouZi GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_MergeTouZi);
        }
        public Dictionary<int, FB_MergeTouZi> GetData()
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
            if (!FB_MergeTouZiContainer.FB_MergeTouZiContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_MergeTouZiContainer.GetRootAsFB_MergeTouZiContainer(bb);
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
