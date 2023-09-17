using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_BloodBaseProvider
    {
        private static FB_BloodBaseProvider _Instance;
        public static FB_BloodBaseProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_BloodBaseProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/BloodBase.txt";
        protected Dictionary<int, FB_BloodBase> mData = new Dictionary<int, FB_BloodBase>();
        private List<FB_BloodBase> mListData = new List<FB_BloodBase>();
        public List<FB_BloodBase> ListData
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
        public FB_BloodBase GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_BloodBase);
        }
        public Dictionary<int, FB_BloodBase> GetData()
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
            if (!FB_BloodBaseContainer.FB_BloodBaseContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_BloodBaseContainer.GetRootAsFB_BloodBaseContainer(bb);
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
