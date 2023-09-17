using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_ShouHuangXiLevelUpProvider
    {
        private static FB_ShouHuangXiLevelUpProvider _Instance;
        public static FB_ShouHuangXiLevelUpProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_ShouHuangXiLevelUpProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/ShouHuangXiLevelUp.txt";
        protected Dictionary<int, FB_ShouHuangXiLevelUp> mData = new Dictionary<int, FB_ShouHuangXiLevelUp>();
        private List<FB_ShouHuangXiLevelUp> mListData = new List<FB_ShouHuangXiLevelUp>();
        public List<FB_ShouHuangXiLevelUp> ListData
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
        public FB_ShouHuangXiLevelUp GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_ShouHuangXiLevelUp);
        }
        public Dictionary<int, FB_ShouHuangXiLevelUp> GetData()
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
            if (!FB_ShouHuangXiLevelUpContainer.FB_ShouHuangXiLevelUpContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_ShouHuangXiLevelUpContainer.GetRootAsFB_ShouHuangXiLevelUpContainer(bb);
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
