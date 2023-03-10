using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_XingHunZhuanJingLevelUpProvider
    {
        private static FB_XingHunZhuanJingLevelUpProvider _Instance;
        public static FB_XingHunZhuanJingLevelUpProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_XingHunZhuanJingLevelUpProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/XingHunZhuanJingLevelUp.txt";
        protected Dictionary<int, FB_XingHunZhuanJingLevelUp> mData = new Dictionary<int, FB_XingHunZhuanJingLevelUp>();
        private List<FB_XingHunZhuanJingLevelUp> mListData = new List<FB_XingHunZhuanJingLevelUp>();
        public List<FB_XingHunZhuanJingLevelUp> ListData
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
        public FB_XingHunZhuanJingLevelUp GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_XingHunZhuanJingLevelUp);
        }
        public Dictionary<int, FB_XingHunZhuanJingLevelUp> GetData()
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
            if (!FB_XingHunZhuanJingLevelUpContainer.FB_XingHunZhuanJingLevelUpContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_XingHunZhuanJingLevelUpContainer.GetRootAsFB_XingHunZhuanJingLevelUpContainer(bb);
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
