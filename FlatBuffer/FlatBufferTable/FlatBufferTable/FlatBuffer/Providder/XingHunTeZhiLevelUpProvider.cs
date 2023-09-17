using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_XingHunTeZhiLevelUpProvider
    {
        private static FB_XingHunTeZhiLevelUpProvider _Instance;
        public static FB_XingHunTeZhiLevelUpProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_XingHunTeZhiLevelUpProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/XingHunTeZhiLevelUp.txt";
        protected Dictionary<int, FB_XingHunTeZhiLevelUp> mData = new Dictionary<int, FB_XingHunTeZhiLevelUp>();
        private List<FB_XingHunTeZhiLevelUp> mListData = new List<FB_XingHunTeZhiLevelUp>();
        public List<FB_XingHunTeZhiLevelUp> ListData
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
        public FB_XingHunTeZhiLevelUp GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_XingHunTeZhiLevelUp);
        }
        public Dictionary<int, FB_XingHunTeZhiLevelUp> GetData()
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
            if (!FB_XingHunTeZhiLevelUpContainer.FB_XingHunTeZhiLevelUpContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_XingHunTeZhiLevelUpContainer.GetRootAsFB_XingHunTeZhiLevelUpContainer(bb);
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
