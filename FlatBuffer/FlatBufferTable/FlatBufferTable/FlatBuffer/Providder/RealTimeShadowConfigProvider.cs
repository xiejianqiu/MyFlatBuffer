using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_RealTimeShadowConfigProvider
    {
        private static FB_RealTimeShadowConfigProvider _Instance;
        public static FB_RealTimeShadowConfigProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_RealTimeShadowConfigProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Client/RealTimeShadowConfig.txt";
        protected Dictionary<int, FB_RealTimeShadowConfig> mData = new Dictionary<int, FB_RealTimeShadowConfig>();
        private List<FB_RealTimeShadowConfig> mListData = new List<FB_RealTimeShadowConfig>();
        public List<FB_RealTimeShadowConfig> ListData
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
        public FB_RealTimeShadowConfig GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_RealTimeShadowConfig);
        }
        public Dictionary<int, FB_RealTimeShadowConfig> GetData()
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
            if (!FB_RealTimeShadowConfigContainer.FB_RealTimeShadowConfigContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_RealTimeShadowConfigContainer.GetRootAsFB_RealTimeShadowConfigContainer(bb);
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
