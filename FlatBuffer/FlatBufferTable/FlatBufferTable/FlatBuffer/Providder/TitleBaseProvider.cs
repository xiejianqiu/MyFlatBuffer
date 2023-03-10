using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_TitleBaseProvider
    {
        private static FB_TitleBaseProvider _Instance;
        public static FB_TitleBaseProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_TitleBaseProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/TitleBase.txt";
        protected Dictionary<int, FB_TitleBase> mData = new Dictionary<int, FB_TitleBase>();
        private List<FB_TitleBase> mListData = new List<FB_TitleBase>();
        public List<FB_TitleBase> ListData
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
        public FB_TitleBase GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_TitleBase);
        }
        public Dictionary<int, FB_TitleBase> GetData()
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
            if (!FB_TitleBaseContainer.FB_TitleBaseContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_TitleBaseContainer.GetRootAsFB_TitleBaseContainer(bb);
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
