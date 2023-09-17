using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_ShenWangLiLianProvider
    {
        private static FB_ShenWangLiLianProvider _Instance;
        public static FB_ShenWangLiLianProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_ShenWangLiLianProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/ShenWangLiLian.txt";
        protected Dictionary<int, FB_ShenWangLiLian> mData = new Dictionary<int, FB_ShenWangLiLian>();
        private List<FB_ShenWangLiLian> mListData = new List<FB_ShenWangLiLian>();
        public List<FB_ShenWangLiLian> ListData
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
        public FB_ShenWangLiLian GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_ShenWangLiLian);
        }
        public Dictionary<int, FB_ShenWangLiLian> GetData()
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
            if (!FB_ShenWangLiLianContainer.FB_ShenWangLiLianContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_ShenWangLiLianContainer.GetRootAsFB_ShenWangLiLianContainer(bb);
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
