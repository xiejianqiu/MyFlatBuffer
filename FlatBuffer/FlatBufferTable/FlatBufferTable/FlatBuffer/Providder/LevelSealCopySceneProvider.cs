using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_LevelSealCopySceneProvider
    {
        private static FB_LevelSealCopySceneProvider _Instance;
        public static FB_LevelSealCopySceneProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_LevelSealCopySceneProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/LevelSealCopyScene.txt";
        protected Dictionary<int, FB_LevelSealCopyScene> mData = new Dictionary<int, FB_LevelSealCopyScene>();
        private List<FB_LevelSealCopyScene> mListData = new List<FB_LevelSealCopyScene>();
        public List<FB_LevelSealCopyScene> ListData
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
        public FB_LevelSealCopyScene GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_LevelSealCopyScene);
        }
        public Dictionary<int, FB_LevelSealCopyScene> GetData()
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
            if (!FB_LevelSealCopySceneContainer.FB_LevelSealCopySceneContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_LevelSealCopySceneContainer.GetRootAsFB_LevelSealCopySceneContainer(bb);
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
