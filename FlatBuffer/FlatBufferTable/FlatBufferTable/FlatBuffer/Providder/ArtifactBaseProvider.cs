using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_ArtifactBaseProvider
    {
        private static FB_ArtifactBaseProvider _Instance;
        public static FB_ArtifactBaseProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_ArtifactBaseProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/ArtifactBase.txt";
        protected Dictionary<int, FB_ArtifactBase> mData = new Dictionary<int, FB_ArtifactBase>();
        private List<FB_ArtifactBase> mListData = new List<FB_ArtifactBase>();
        public List<FB_ArtifactBase> ListData
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
        public FB_ArtifactBase GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_ArtifactBase);
        }
        public Dictionary<int, FB_ArtifactBase> GetData()
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
            if (!FB_ArtifactBaseContainer.FB_ArtifactBaseContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_ArtifactBaseContainer.GetRootAsFB_ArtifactBaseContainer(bb);
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
