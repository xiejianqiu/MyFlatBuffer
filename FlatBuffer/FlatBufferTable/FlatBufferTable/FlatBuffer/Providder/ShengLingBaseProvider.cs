using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_ShengLingBaseProvider
    {
        private static FB_ShengLingBaseProvider _Instance;
        public static FB_ShengLingBaseProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_ShengLingBaseProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/ShengLingBase.txt";
        protected Dictionary<int, FB_ShengLingBase> mData = new Dictionary<int, FB_ShengLingBase>();
        private List<FB_ShengLingBase> mListData = new List<FB_ShengLingBase>();
        public List<FB_ShengLingBase> ListData
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
        public FB_ShengLingBase GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_ShengLingBase);
        }
        public Dictionary<int, FB_ShengLingBase> GetData()
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
            if (!FB_ShengLingBaseContainer.FB_ShengLingBaseContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_ShengLingBaseContainer.GetRootAsFB_ShengLingBaseContainer(bb);
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
