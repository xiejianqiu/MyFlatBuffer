using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_KneadFaceOfTattoProvider
    {
        private static FB_KneadFaceOfTattoProvider _Instance;
        public static FB_KneadFaceOfTattoProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_KneadFaceOfTattoProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Client/KneadFaceOfTatto.txt";
        protected Dictionary<int, FB_KneadFaceOfTatto> mData = new Dictionary<int, FB_KneadFaceOfTatto>();
        private List<FB_KneadFaceOfTatto> mListData = new List<FB_KneadFaceOfTatto>();
        public List<FB_KneadFaceOfTatto> ListData
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
        public FB_KneadFaceOfTatto GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_KneadFaceOfTatto);
        }
        public Dictionary<int, FB_KneadFaceOfTatto> GetData()
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
            if (!FB_KneadFaceOfTattoContainer.FB_KneadFaceOfTattoContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_KneadFaceOfTattoContainer.GetRootAsFB_KneadFaceOfTattoContainer(bb);
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
