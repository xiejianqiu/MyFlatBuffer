using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_ActWanGuPropLevelBaseProvider
    {
        private static FB_ActWanGuPropLevelBaseProvider _Instance;
        public static FB_ActWanGuPropLevelBaseProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_ActWanGuPropLevelBaseProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/ActWanGuPropLevelBase.txt";
        protected Dictionary<int, FB_ActWanGuPropLevelBase> mData = new Dictionary<int, FB_ActWanGuPropLevelBase>();
        private List<FB_ActWanGuPropLevelBase> mListData = new List<FB_ActWanGuPropLevelBase>();
        public List<FB_ActWanGuPropLevelBase> ListData
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
        public FB_ActWanGuPropLevelBase GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_ActWanGuPropLevelBase);
        }
        public Dictionary<int, FB_ActWanGuPropLevelBase> GetData()
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
            if (!FB_ActWanGuPropLevelBaseContainer.FB_ActWanGuPropLevelBaseContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_ActWanGuPropLevelBaseContainer.GetRootAsFB_ActWanGuPropLevelBaseContainer(bb);
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
