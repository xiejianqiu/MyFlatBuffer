using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_ShengLingCopySceneTypeProvider
    {
        private static FB_ShengLingCopySceneTypeProvider _Instance;
        public static FB_ShengLingCopySceneTypeProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_ShengLingCopySceneTypeProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/ShengLingCopySceneType.txt";
        protected Dictionary<int, FB_ShengLingCopySceneType> mData = new Dictionary<int, FB_ShengLingCopySceneType>();
        private List<FB_ShengLingCopySceneType> mListData = new List<FB_ShengLingCopySceneType>();
        public List<FB_ShengLingCopySceneType> ListData
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
        public FB_ShengLingCopySceneType GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_ShengLingCopySceneType);
        }
        public Dictionary<int, FB_ShengLingCopySceneType> GetData()
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
            if (!FB_ShengLingCopySceneTypeContainer.FB_ShengLingCopySceneTypeContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_ShengLingCopySceneTypeContainer.GetRootAsFB_ShengLingCopySceneTypeContainer(bb);
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
