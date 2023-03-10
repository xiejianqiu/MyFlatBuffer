using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_CopySceneStageDicProvider
    {
        private static FB_CopySceneStageDicProvider _Instance;
        public static FB_CopySceneStageDicProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_CopySceneStageDicProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/CopySceneStageDic.txt";
        protected Dictionary<int, FB_CopySceneStageDic> mData = new Dictionary<int, FB_CopySceneStageDic>();
        private List<FB_CopySceneStageDic> mListData = new List<FB_CopySceneStageDic>();
        public List<FB_CopySceneStageDic> ListData
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
        public FB_CopySceneStageDic GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_CopySceneStageDic);
        }
        public Dictionary<int, FB_CopySceneStageDic> GetData()
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
            if (!FB_CopySceneStageDicContainer.FB_CopySceneStageDicContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_CopySceneStageDicContainer.GetRootAsFB_CopySceneStageDicContainer(bb);
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
