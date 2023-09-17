using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_ShenWangZhanJiaMakeLevelUpProvider
    {
        private static FB_ShenWangZhanJiaMakeLevelUpProvider _Instance;
        public static FB_ShenWangZhanJiaMakeLevelUpProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_ShenWangZhanJiaMakeLevelUpProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/ShenWangZhanJiaMakeLevelUp.txt";
        protected Dictionary<int, FB_ShenWangZhanJiaMakeLevelUp> mData = new Dictionary<int, FB_ShenWangZhanJiaMakeLevelUp>();
        private List<FB_ShenWangZhanJiaMakeLevelUp> mListData = new List<FB_ShenWangZhanJiaMakeLevelUp>();
        public List<FB_ShenWangZhanJiaMakeLevelUp> ListData
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
        public FB_ShenWangZhanJiaMakeLevelUp GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_ShenWangZhanJiaMakeLevelUp);
        }
        public Dictionary<int, FB_ShenWangZhanJiaMakeLevelUp> GetData()
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
            if (!FB_ShenWangZhanJiaMakeLevelUpContainer.FB_ShenWangZhanJiaMakeLevelUpContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_ShenWangZhanJiaMakeLevelUpContainer.GetRootAsFB_ShenWangZhanJiaMakeLevelUpContainer(bb);
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
