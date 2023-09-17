using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_ShenWangZhanJiaPracticeLevelUpProvider
    {
        private static FB_ShenWangZhanJiaPracticeLevelUpProvider _Instance;
        public static FB_ShenWangZhanJiaPracticeLevelUpProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_ShenWangZhanJiaPracticeLevelUpProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/ShenWangZhanJiaPracticeLevelUp.txt";
        protected Dictionary<int, FB_ShenWangZhanJiaPracticeLevelUp> mData = new Dictionary<int, FB_ShenWangZhanJiaPracticeLevelUp>();
        private List<FB_ShenWangZhanJiaPracticeLevelUp> mListData = new List<FB_ShenWangZhanJiaPracticeLevelUp>();
        public List<FB_ShenWangZhanJiaPracticeLevelUp> ListData
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
        public FB_ShenWangZhanJiaPracticeLevelUp GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_ShenWangZhanJiaPracticeLevelUp);
        }
        public Dictionary<int, FB_ShenWangZhanJiaPracticeLevelUp> GetData()
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
            if (!FB_ShenWangZhanJiaPracticeLevelUpContainer.FB_ShenWangZhanJiaPracticeLevelUpContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_ShenWangZhanJiaPracticeLevelUpContainer.GetRootAsFB_ShenWangZhanJiaPracticeLevelUpContainer(bb);
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
