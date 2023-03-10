using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_JieYuanSlotResonanceProvider
    {
        private static FB_JieYuanSlotResonanceProvider _Instance;
        public static FB_JieYuanSlotResonanceProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_JieYuanSlotResonanceProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/JieYuanSlotResonance.txt";
        protected Dictionary<int, FB_JieYuanSlotResonance> mData = new Dictionary<int, FB_JieYuanSlotResonance>();
        private List<FB_JieYuanSlotResonance> mListData = new List<FB_JieYuanSlotResonance>();
        public List<FB_JieYuanSlotResonance> ListData
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
        public FB_JieYuanSlotResonance GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_JieYuanSlotResonance);
        }
        public Dictionary<int, FB_JieYuanSlotResonance> GetData()
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
            if (!FB_JieYuanSlotResonanceContainer.FB_JieYuanSlotResonanceContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_JieYuanSlotResonanceContainer.GetRootAsFB_JieYuanSlotResonanceContainer(bb);
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
