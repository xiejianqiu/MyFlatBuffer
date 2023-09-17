using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_GuideBaseProvider
    {
        private static FB_GuideBaseProvider _Instance;
        public static FB_GuideBaseProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_GuideBaseProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Client/GuideBase.txt";
        protected Dictionary<int, FB_GuideBase> mData = new Dictionary<int, FB_GuideBase>();
        private List<FB_GuideBase> mListData = new List<FB_GuideBase>();
        public List<FB_GuideBase> ListData
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
        public FB_GuideBase GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_GuideBase);
        }
        public Dictionary<int, FB_GuideBase> GetData()
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
            if (!FB_GuideBaseContainer.FB_GuideBaseContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_GuideBaseContainer.GetRootAsFB_GuideBaseContainer(bb);
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
