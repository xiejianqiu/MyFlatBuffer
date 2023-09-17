using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_BloodMixProvider
    {
        private static FB_BloodMixProvider _Instance;
        public static FB_BloodMixProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_BloodMixProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/BloodMix.txt";
        protected Dictionary<int, FB_BloodMix> mData = new Dictionary<int, FB_BloodMix>();
        private List<FB_BloodMix> mListData = new List<FB_BloodMix>();
        public List<FB_BloodMix> ListData
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
        public FB_BloodMix GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_BloodMix);
        }
        public Dictionary<int, FB_BloodMix> GetData()
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
            if (!FB_BloodMixContainer.FB_BloodMixContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_BloodMixContainer.GetRootAsFB_BloodMixContainer(bb);
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
