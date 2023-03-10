using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_FlyCutterUIProvider
    {
        private static FB_FlyCutterUIProvider _Instance;
        public static FB_FlyCutterUIProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_FlyCutterUIProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Client/FlyCutterUI.txt";
        protected Dictionary<int, FB_FlyCutterUI> mData = new Dictionary<int, FB_FlyCutterUI>();
        private List<FB_FlyCutterUI> mListData = new List<FB_FlyCutterUI>();
        public List<FB_FlyCutterUI> ListData
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
        public FB_FlyCutterUI GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_FlyCutterUI);
        }
        public Dictionary<int, FB_FlyCutterUI> GetData()
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
            if (!FB_FlyCutterUIContainer.FB_FlyCutterUIContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_FlyCutterUIContainer.GetRootAsFB_FlyCutterUIContainer(bb);
            for (int index = 0; index < data.ItemsLength; index++)
            {
                var item = data.GetItems(index);
                mData.Add(item.Level, item);
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
