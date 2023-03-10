using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_SoulPowerJieUpProvider
    {
        private static FB_SoulPowerJieUpProvider _Instance;
        public static FB_SoulPowerJieUpProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_SoulPowerJieUpProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/SoulPowerJieUp.txt";
        protected Dictionary<int, FB_SoulPowerJieUp> mData = new Dictionary<int, FB_SoulPowerJieUp>();
        private List<FB_SoulPowerJieUp> mListData = new List<FB_SoulPowerJieUp>();
        public List<FB_SoulPowerJieUp> ListData
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
        public FB_SoulPowerJieUp GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_SoulPowerJieUp);
        }
        public Dictionary<int, FB_SoulPowerJieUp> GetData()
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
            if (!FB_SoulPowerJieUpContainer.FB_SoulPowerJieUpContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_SoulPowerJieUpContainer.GetRootAsFB_SoulPowerJieUpContainer(bb);
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
