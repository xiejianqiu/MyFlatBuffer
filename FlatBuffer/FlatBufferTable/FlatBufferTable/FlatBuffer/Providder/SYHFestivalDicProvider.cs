using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_SYHFestivalDicProvider
    {
        private static FB_SYHFestivalDicProvider _Instance;
        public static FB_SYHFestivalDicProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_SYHFestivalDicProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Client/SYHFestivalDic.txt";
        protected Dictionary<int, FB_SYHFestivalDic> mData = new Dictionary<int, FB_SYHFestivalDic>();
        private List<FB_SYHFestivalDic> mListData = new List<FB_SYHFestivalDic>();
        public List<FB_SYHFestivalDic> ListData
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
        public FB_SYHFestivalDic GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_SYHFestivalDic);
        }
        public Dictionary<int, FB_SYHFestivalDic> GetData()
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
            if (!FB_SYHFestivalDicContainer.FB_SYHFestivalDicContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_SYHFestivalDicContainer.GetRootAsFB_SYHFestivalDicContainer(bb);
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
