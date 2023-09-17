using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_ShenWangZhanJiaCsBaseProvider
    {
        private static FB_ShenWangZhanJiaCsBaseProvider _Instance;
        public static FB_ShenWangZhanJiaCsBaseProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_ShenWangZhanJiaCsBaseProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/ShenWangZhanJiaCsBase.txt";
        protected Dictionary<int, FB_ShenWangZhanJiaCsBase> mData = new Dictionary<int, FB_ShenWangZhanJiaCsBase>();
        private List<FB_ShenWangZhanJiaCsBase> mListData = new List<FB_ShenWangZhanJiaCsBase>();
        public List<FB_ShenWangZhanJiaCsBase> ListData
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
        public FB_ShenWangZhanJiaCsBase GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_ShenWangZhanJiaCsBase);
        }
        public Dictionary<int, FB_ShenWangZhanJiaCsBase> GetData()
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
            if (!FB_ShenWangZhanJiaCsBaseContainer.FB_ShenWangZhanJiaCsBaseContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_ShenWangZhanJiaCsBaseContainer.GetRootAsFB_ShenWangZhanJiaCsBaseContainer(bb);
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
