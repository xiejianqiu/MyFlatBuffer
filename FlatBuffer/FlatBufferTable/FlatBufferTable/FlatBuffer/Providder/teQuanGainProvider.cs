using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_teQuanGainProvider
    {
        private static FB_teQuanGainProvider _Instance;
        public static FB_teQuanGainProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_teQuanGainProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/teQuanGain.txt";
        protected Dictionary<int, FB_teQuanGain> mData = new Dictionary<int, FB_teQuanGain>();
        private List<FB_teQuanGain> mListData = new List<FB_teQuanGain>();
        public List<FB_teQuanGain> ListData
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
        public FB_teQuanGain GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_teQuanGain);
        }
        public Dictionary<int, FB_teQuanGain> GetData()
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
            if (!FB_teQuanGainContainer.FB_teQuanGainContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_teQuanGainContainer.GetRootAsFB_teQuanGainContainer(bb);
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
