using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_KneadFaceOfPrefabProvider
    {
        private static FB_KneadFaceOfPrefabProvider _Instance;
        public static FB_KneadFaceOfPrefabProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_KneadFaceOfPrefabProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Client/KneadFaceOfPrefab.txt";
        protected Dictionary<int, FB_KneadFaceOfPrefab> mData = new Dictionary<int, FB_KneadFaceOfPrefab>();
        private List<FB_KneadFaceOfPrefab> mListData = new List<FB_KneadFaceOfPrefab>();
        public List<FB_KneadFaceOfPrefab> ListData
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
        public FB_KneadFaceOfPrefab GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_KneadFaceOfPrefab);
        }
        public Dictionary<int, FB_KneadFaceOfPrefab> GetData()
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
            if (!FB_KneadFaceOfPrefabContainer.FB_KneadFaceOfPrefabContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_KneadFaceOfPrefabContainer.GetRootAsFB_KneadFaceOfPrefabContainer(bb);
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
