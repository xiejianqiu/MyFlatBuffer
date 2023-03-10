using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_KneadFaceOClothingProvider
    {
        private static FB_KneadFaceOClothingProvider _Instance;
        public static FB_KneadFaceOClothingProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_KneadFaceOClothingProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/KneadFaceOClothing.txt";
        protected Dictionary<int, FB_KneadFaceOClothing> mData = new Dictionary<int, FB_KneadFaceOClothing>();
        private List<FB_KneadFaceOClothing> mListData = new List<FB_KneadFaceOClothing>();
        public List<FB_KneadFaceOClothing> ListData
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
        public FB_KneadFaceOClothing GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_KneadFaceOClothing);
        }
        public Dictionary<int, FB_KneadFaceOClothing> GetData()
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
            if (!FB_KneadFaceOClothingContainer.FB_KneadFaceOClothingContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_KneadFaceOClothingContainer.GetRootAsFB_KneadFaceOClothingContainer(bb);
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
