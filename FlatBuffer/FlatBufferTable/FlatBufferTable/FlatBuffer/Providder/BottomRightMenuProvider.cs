using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_BottomRightMenuProvider
    {
        private static FB_BottomRightMenuProvider _Instance;
        public static FB_BottomRightMenuProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_BottomRightMenuProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Client/BottomRightMenu.txt";
        protected Dictionary<int, FB_BottomRightMenu> mData = new Dictionary<int, FB_BottomRightMenu>();
        private List<FB_BottomRightMenu> mListData = new List<FB_BottomRightMenu>();
        public List<FB_BottomRightMenu> ListData
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
        public FB_BottomRightMenu GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_BottomRightMenu);
        }
        public Dictionary<int, FB_BottomRightMenu> GetData()
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
            if (!FB_BottomRightMenuContainer.FB_BottomRightMenuContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_BottomRightMenuContainer.GetRootAsFB_BottomRightMenuContainer(bb);
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
