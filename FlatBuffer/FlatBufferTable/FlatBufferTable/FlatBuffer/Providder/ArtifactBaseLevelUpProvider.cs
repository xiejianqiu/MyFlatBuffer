using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_ArtifactBaseLevelUpProvider
    {
        private static FB_ArtifactBaseLevelUpProvider _Instance;
        public static FB_ArtifactBaseLevelUpProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_ArtifactBaseLevelUpProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/ArtifactBaseLevelUp.txt";
        protected Dictionary<int, FB_ArtifactBaseLevelUp> mData = new Dictionary<int, FB_ArtifactBaseLevelUp>();
        private List<FB_ArtifactBaseLevelUp> mListData = new List<FB_ArtifactBaseLevelUp>();
        public List<FB_ArtifactBaseLevelUp> ListData
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
        public FB_ArtifactBaseLevelUp GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_ArtifactBaseLevelUp);
        }
        public Dictionary<int, FB_ArtifactBaseLevelUp> GetData()
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
            if (!FB_ArtifactBaseLevelUpContainer.FB_ArtifactBaseLevelUpContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_ArtifactBaseLevelUpContainer.GetRootAsFB_ArtifactBaseLevelUpContainer(bb);
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
