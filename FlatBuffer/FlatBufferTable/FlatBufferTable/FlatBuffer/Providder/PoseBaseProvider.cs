using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_PoseBaseProvider
    {
        private static FB_PoseBaseProvider _Instance;
        public static FB_PoseBaseProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_PoseBaseProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/PoseBase.txt";
        protected Dictionary<int, FB_PoseBase> mData = new Dictionary<int, FB_PoseBase>();
        private List<FB_PoseBase> mListData = new List<FB_PoseBase>();
        public List<FB_PoseBase> ListData
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
        public FB_PoseBase GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_PoseBase);
        }
        public Dictionary<int, FB_PoseBase> GetData()
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
            if (!FB_PoseBaseContainer.FB_PoseBaseContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_PoseBaseContainer.GetRootAsFB_PoseBaseContainer(bb);
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
