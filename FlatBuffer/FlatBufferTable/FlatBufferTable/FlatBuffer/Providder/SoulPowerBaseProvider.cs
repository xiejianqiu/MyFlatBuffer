using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_SoulPowerBaseProvider
    {
        private static FB_SoulPowerBaseProvider _Instance;
        public static FB_SoulPowerBaseProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_SoulPowerBaseProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/SoulPowerBase.txt";
        protected Dictionary<int, FB_SoulPowerBase> mData = new Dictionary<int, FB_SoulPowerBase>();
        private List<FB_SoulPowerBase> mListData = new List<FB_SoulPowerBase>();
        public List<FB_SoulPowerBase> ListData
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
        public FB_SoulPowerBase GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_SoulPowerBase);
        }
        public Dictionary<int, FB_SoulPowerBase> GetData()
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
            if (!FB_SoulPowerBaseContainer.FB_SoulPowerBaseContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_SoulPowerBaseContainer.GetRootAsFB_SoulPowerBaseContainer(bb);
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
