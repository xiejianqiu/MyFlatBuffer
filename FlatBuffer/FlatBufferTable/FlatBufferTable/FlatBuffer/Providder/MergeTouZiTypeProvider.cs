using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_MergeTouZiTypeProvider
    {
        private static FB_MergeTouZiTypeProvider _Instance;
        public static FB_MergeTouZiTypeProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_MergeTouZiTypeProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/MergeTouZiType.txt";
        protected Dictionary<int, FB_MergeTouZiType> mData = new Dictionary<int, FB_MergeTouZiType>();
        private List<FB_MergeTouZiType> mListData = new List<FB_MergeTouZiType>();
        public List<FB_MergeTouZiType> ListData
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
        public FB_MergeTouZiType GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_MergeTouZiType);
        }
        public Dictionary<int, FB_MergeTouZiType> GetData()
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
            if (!FB_MergeTouZiTypeContainer.FB_MergeTouZiTypeContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_MergeTouZiTypeContainer.GetRootAsFB_MergeTouZiTypeContainer(bb);
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
