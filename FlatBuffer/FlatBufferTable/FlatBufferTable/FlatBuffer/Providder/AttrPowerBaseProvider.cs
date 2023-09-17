using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_AttrPowerBaseProvider
    {
        private static FB_AttrPowerBaseProvider _Instance;
        public static FB_AttrPowerBaseProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_AttrPowerBaseProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/AttrPowerBase.txt";
        protected Dictionary<int, FB_AttrPowerBase> mData = new Dictionary<int, FB_AttrPowerBase>();
        private List<FB_AttrPowerBase> mListData = new List<FB_AttrPowerBase>();
        public List<FB_AttrPowerBase> ListData
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
        public FB_AttrPowerBase GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_AttrPowerBase);
        }
        public Dictionary<int, FB_AttrPowerBase> GetData()
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
            if (!FB_AttrPowerBaseContainer.FB_AttrPowerBaseContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_AttrPowerBaseContainer.GetRootAsFB_AttrPowerBaseContainer(bb);
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
