using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_YingYanBaseProvider
    {
        private static FB_YingYanBaseProvider _Instance;
        public static FB_YingYanBaseProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_YingYanBaseProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/YingYanBase.txt";
        protected Dictionary<int, FB_YingYanBase> mData = new Dictionary<int, FB_YingYanBase>();
        private List<FB_YingYanBase> mListData = new List<FB_YingYanBase>();
        public List<FB_YingYanBase> ListData
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
        public FB_YingYanBase GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_YingYanBase);
        }
        public Dictionary<int, FB_YingYanBase> GetData()
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
            if (!FB_YingYanBaseContainer.FB_YingYanBaseContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_YingYanBaseContainer.GetRootAsFB_YingYanBaseContainer(bb);
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
