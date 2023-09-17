using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_ClientStoryTableProvider
    {
        private static FB_ClientStoryTableProvider _Instance;
        public static FB_ClientStoryTableProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_ClientStoryTableProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Client/ClientStoryTable.txt";
        protected Dictionary<int, FB_ClientStoryTable> mData = new Dictionary<int, FB_ClientStoryTable>();
        private List<FB_ClientStoryTable> mListData = new List<FB_ClientStoryTable>();
        public List<FB_ClientStoryTable> ListData
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
        public FB_ClientStoryTable GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_ClientStoryTable);
        }
        public Dictionary<int, FB_ClientStoryTable> GetData()
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
            if (!FB_ClientStoryTableContainer.FB_ClientStoryTableContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_ClientStoryTableContainer.GetRootAsFB_ClientStoryTableContainer(bb);
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
