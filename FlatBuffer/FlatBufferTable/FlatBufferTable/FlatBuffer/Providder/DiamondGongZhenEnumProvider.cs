using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_DiamondGongZhenEnumProvider
    {
        private static FB_DiamondGongZhenEnumProvider _Instance;
        public static FB_DiamondGongZhenEnumProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_DiamondGongZhenEnumProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/DiamondGongZhenEnum.txt";
        protected Dictionary<int, FB_DiamondGongZhenEnum> mData = new Dictionary<int, FB_DiamondGongZhenEnum>();
        private List<FB_DiamondGongZhenEnum> mListData = new List<FB_DiamondGongZhenEnum>();
        public List<FB_DiamondGongZhenEnum> ListData
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
        public FB_DiamondGongZhenEnum GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_DiamondGongZhenEnum);
        }
        public Dictionary<int, FB_DiamondGongZhenEnum> GetData()
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
            if (!FB_DiamondGongZhenEnumContainer.FB_DiamondGongZhenEnumContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_DiamondGongZhenEnumContainer.GetRootAsFB_DiamondGongZhenEnumContainer(bb);
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
