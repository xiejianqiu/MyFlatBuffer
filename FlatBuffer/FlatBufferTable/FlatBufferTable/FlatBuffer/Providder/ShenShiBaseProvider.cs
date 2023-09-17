using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_ShenShiBaseProvider
    {
        private static FB_ShenShiBaseProvider _Instance;
        public static FB_ShenShiBaseProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_ShenShiBaseProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/ShenShiBase.txt";
        protected Dictionary<int, FB_ShenShiBase> mData = new Dictionary<int, FB_ShenShiBase>();
        private List<FB_ShenShiBase> mListData = new List<FB_ShenShiBase>();
        public List<FB_ShenShiBase> ListData
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
        public FB_ShenShiBase GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_ShenShiBase);
        }
        public Dictionary<int, FB_ShenShiBase> GetData()
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
            if (!FB_ShenShiBaseContainer.FB_ShenShiBaseContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_ShenShiBaseContainer.GetRootAsFB_ShenShiBaseContainer(bb);
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
