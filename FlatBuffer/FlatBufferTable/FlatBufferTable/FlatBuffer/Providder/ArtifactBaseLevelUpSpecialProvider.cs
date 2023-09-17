using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_ArtifactBaseLevelUpSpecialProvider
    {
        private static FB_ArtifactBaseLevelUpSpecialProvider _Instance;
        public static FB_ArtifactBaseLevelUpSpecialProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_ArtifactBaseLevelUpSpecialProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/ArtifactBaseLevelUpSpecial.txt";
        protected Dictionary<int, FB_ArtifactBaseLevelUpSpecial> mData = new Dictionary<int, FB_ArtifactBaseLevelUpSpecial>();
        private List<FB_ArtifactBaseLevelUpSpecial> mListData = new List<FB_ArtifactBaseLevelUpSpecial>();
        public List<FB_ArtifactBaseLevelUpSpecial> ListData
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
        public FB_ArtifactBaseLevelUpSpecial GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_ArtifactBaseLevelUpSpecial);
        }
        public Dictionary<int, FB_ArtifactBaseLevelUpSpecial> GetData()
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
            if (!FB_ArtifactBaseLevelUpSpecialContainer.FB_ArtifactBaseLevelUpSpecialContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_ArtifactBaseLevelUpSpecialContainer.GetRootAsFB_ArtifactBaseLevelUpSpecialContainer(bb);
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
