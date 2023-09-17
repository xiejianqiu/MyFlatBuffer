using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_ShenShouBaseProvider
    {
        private static FB_ShenShouBaseProvider _Instance;
        public static FB_ShenShouBaseProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_ShenShouBaseProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/ShenShouBase.txt";
        protected Dictionary<int, FB_ShenShouBase> mData = new Dictionary<int, FB_ShenShouBase>();
        private List<FB_ShenShouBase> mListData = new List<FB_ShenShouBase>();
        public List<FB_ShenShouBase> ListData
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
        public FB_ShenShouBase GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_ShenShouBase);
        }
        public Dictionary<int, FB_ShenShouBase> GetData()
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
            if (!FB_ShenShouBaseContainer.FB_ShenShouBaseContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_ShenShouBaseContainer.GetRootAsFB_ShenShouBaseContainer(bb);
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
