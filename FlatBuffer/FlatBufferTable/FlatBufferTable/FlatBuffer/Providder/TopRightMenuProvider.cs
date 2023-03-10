using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_TopRightMenuProvider
    {
        private static FB_TopRightMenuProvider _Instance;
        public static FB_TopRightMenuProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_TopRightMenuProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Client/TopRightMenu.txt";
        protected Dictionary<int, FB_TopRightMenu> mData = new Dictionary<int, FB_TopRightMenu>();
        private List<FB_TopRightMenu> mListData = new List<FB_TopRightMenu>();
        public List<FB_TopRightMenu> ListData
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
        public FB_TopRightMenu GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_TopRightMenu);
        }
        public Dictionary<int, FB_TopRightMenu> GetData()
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
            if (!FB_TopRightMenuContainer.FB_TopRightMenuContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_TopRightMenuContainer.GetRootAsFB_TopRightMenuContainer(bb);
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
