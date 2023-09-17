using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_UISpecialHideProvider
    {
        private static FB_UISpecialHideProvider _Instance;
        public static FB_UISpecialHideProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_UISpecialHideProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Client/UISpecialHide.txt";
        protected Dictionary<int, FB_UISpecialHide> mData = new Dictionary<int, FB_UISpecialHide>();
        private List<FB_UISpecialHide> mListData = new List<FB_UISpecialHide>();
        public List<FB_UISpecialHide> ListData
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
        public FB_UISpecialHide GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_UISpecialHide);
        }
        public Dictionary<int, FB_UISpecialHide> GetData()
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
            if (!FB_UISpecialHideContainer.FB_UISpecialHideContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_UISpecialHideContainer.GetRootAsFB_UISpecialHideContainer(bb);
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
