using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_ClientConfigProvider
    {
        private static FB_ClientConfigProvider _Instance;
        public static FB_ClientConfigProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_ClientConfigProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/ClientConfig.txt";
        protected Dictionary<int, FB_ClientConfig> mData = new Dictionary<int, FB_ClientConfig>();
        private List<FB_ClientConfig> mListData = new List<FB_ClientConfig>();
        public List<FB_ClientConfig> ListData
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
        public FB_ClientConfig GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_ClientConfig);
        }
        public Dictionary<int, FB_ClientConfig> GetData()
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
            if (!FB_ClientConfigContainer.FB_ClientConfigContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_ClientConfigContainer.GetRootAsFB_ClientConfigContainer(bb);
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
