using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_MissionCopySceneProvider
    {
        private static FB_MissionCopySceneProvider _Instance;
        public static FB_MissionCopySceneProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_MissionCopySceneProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/MissionCopyScene.txt";
        protected Dictionary<int, FB_MissionCopyScene> mData = new Dictionary<int, FB_MissionCopyScene>();
        private List<FB_MissionCopyScene> mListData = new List<FB_MissionCopyScene>();
        public List<FB_MissionCopyScene> ListData
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
        public FB_MissionCopyScene GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_MissionCopyScene);
        }
        public Dictionary<int, FB_MissionCopyScene> GetData()
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
            if (!FB_MissionCopySceneContainer.FB_MissionCopySceneContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_MissionCopySceneContainer.GetRootAsFB_MissionCopySceneContainer(bb);
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
