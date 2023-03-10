using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_MarryTitleBaseProvider
    {
        private static FB_MarryTitleBaseProvider _Instance;
        public static FB_MarryTitleBaseProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_MarryTitleBaseProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/MarryTitleBase.txt";
        protected Dictionary<int, FB_MarryTitleBase> mData = new Dictionary<int, FB_MarryTitleBase>();
        private List<FB_MarryTitleBase> mListData = new List<FB_MarryTitleBase>();
        public List<FB_MarryTitleBase> ListData
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
        public FB_MarryTitleBase GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_MarryTitleBase);
        }
        public Dictionary<int, FB_MarryTitleBase> GetData()
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
            if (!FB_MarryTitleBaseContainer.FB_MarryTitleBaseContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_MarryTitleBaseContainer.GetRootAsFB_MarryTitleBaseContainer(bb);
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
