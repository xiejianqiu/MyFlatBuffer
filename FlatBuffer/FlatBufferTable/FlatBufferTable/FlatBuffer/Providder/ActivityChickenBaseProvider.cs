using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_ActivityChickenBaseProvider
    {
        private static FB_ActivityChickenBaseProvider _Instance;
        public static FB_ActivityChickenBaseProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_ActivityChickenBaseProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/ActivityChickenBase.txt";
        protected Dictionary<int, FB_ActivityChickenBase> mData = new Dictionary<int, FB_ActivityChickenBase>();
        private List<FB_ActivityChickenBase> mListData = new List<FB_ActivityChickenBase>();
        public List<FB_ActivityChickenBase> ListData
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
        public FB_ActivityChickenBase GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_ActivityChickenBase);
        }
        public Dictionary<int, FB_ActivityChickenBase> GetData()
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
            if (!FB_ActivityChickenBaseContainer.FB_ActivityChickenBaseContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_ActivityChickenBaseContainer.GetRootAsFB_ActivityChickenBaseContainer(bb);
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
