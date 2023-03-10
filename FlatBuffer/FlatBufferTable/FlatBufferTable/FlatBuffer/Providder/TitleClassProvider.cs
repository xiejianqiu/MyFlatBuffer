using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_TitleClassProvider
    {
        private static FB_TitleClassProvider _Instance;
        public static FB_TitleClassProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_TitleClassProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/TitleClass.txt";
        protected Dictionary<int, FB_TitleClass> mData = new Dictionary<int, FB_TitleClass>();
        private List<FB_TitleClass> mListData = new List<FB_TitleClass>();
        public List<FB_TitleClass> ListData
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
        public FB_TitleClass GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_TitleClass);
        }
        public Dictionary<int, FB_TitleClass> GetData()
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
            if (!FB_TitleClassContainer.FB_TitleClassContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_TitleClassContainer.GetRootAsFB_TitleClassContainer(bb);
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
