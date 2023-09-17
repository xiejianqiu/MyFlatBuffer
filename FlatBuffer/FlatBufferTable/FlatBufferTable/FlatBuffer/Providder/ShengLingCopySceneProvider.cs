using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_ShengLingCopySceneProvider
    {
        private static FB_ShengLingCopySceneProvider _Instance;
        public static FB_ShengLingCopySceneProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_ShengLingCopySceneProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/ShengLingCopyScene.txt";
        protected Dictionary<int, FB_ShengLingCopyScene> mData = new Dictionary<int, FB_ShengLingCopyScene>();
        private List<FB_ShengLingCopyScene> mListData = new List<FB_ShengLingCopyScene>();
        public List<FB_ShengLingCopyScene> ListData
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
        public FB_ShengLingCopyScene GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_ShengLingCopyScene);
        }
        public Dictionary<int, FB_ShengLingCopyScene> GetData()
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
            if (!FB_ShengLingCopySceneContainer.FB_ShengLingCopySceneContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_ShengLingCopySceneContainer.GetRootAsFB_ShengLingCopySceneContainer(bb);
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
