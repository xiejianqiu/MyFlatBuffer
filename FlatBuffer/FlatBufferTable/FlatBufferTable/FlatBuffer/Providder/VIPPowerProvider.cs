using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_VIPPowerProvider
    {
        private static FB_VIPPowerProvider _Instance;
        public static FB_VIPPowerProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_VIPPowerProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/VIPPower.txt";
        protected Dictionary<int, FB_VIPPower> mData = new Dictionary<int, FB_VIPPower>();
        private List<FB_VIPPower> mListData = new List<FB_VIPPower>();
        public List<FB_VIPPower> ListData
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
        public FB_VIPPower GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_VIPPower);
        }
        public Dictionary<int, FB_VIPPower> GetData()
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
            if (!FB_VIPPowerContainer.FB_VIPPowerContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_VIPPowerContainer.GetRootAsFB_VIPPowerContainer(bb);
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
