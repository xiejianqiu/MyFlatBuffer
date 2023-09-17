using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_UISubPanelPathProvider
    {
        private static FB_UISubPanelPathProvider _Instance;
        public static FB_UISubPanelPathProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_UISubPanelPathProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Client/UISubPanelPath.txt";
        protected Dictionary<int, FB_UISubPanelPath> mData = new Dictionary<int, FB_UISubPanelPath>();
        private List<FB_UISubPanelPath> mListData = new List<FB_UISubPanelPath>();
        public List<FB_UISubPanelPath> ListData
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
        public FB_UISubPanelPath GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_UISubPanelPath);
        }
        public Dictionary<int, FB_UISubPanelPath> GetData()
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
            if (!FB_UISubPanelPathContainer.FB_UISubPanelPathContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_UISubPanelPathContainer.GetRootAsFB_UISubPanelPathContainer(bb);
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
