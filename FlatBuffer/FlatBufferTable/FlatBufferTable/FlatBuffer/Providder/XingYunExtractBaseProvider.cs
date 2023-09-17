using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_XingYunExtractBaseProvider
    {
        private static FB_XingYunExtractBaseProvider _Instance;
        public static FB_XingYunExtractBaseProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_XingYunExtractBaseProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/XingYunExtractBase.txt";
        protected Dictionary<int, FB_XingYunExtractBase> mData = new Dictionary<int, FB_XingYunExtractBase>();
        private List<FB_XingYunExtractBase> mListData = new List<FB_XingYunExtractBase>();
        public List<FB_XingYunExtractBase> ListData
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
        public FB_XingYunExtractBase GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_XingYunExtractBase);
        }
        public Dictionary<int, FB_XingYunExtractBase> GetData()
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
            if (!FB_XingYunExtractBaseContainer.FB_XingYunExtractBaseContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_XingYunExtractBaseContainer.GetRootAsFB_XingYunExtractBaseContainer(bb);
            for (int index = 0; index < data.ItemsLength; index++)
            {
                var item = data.GetItems(index);
                mData.Add(item.ExtractId, item);
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
