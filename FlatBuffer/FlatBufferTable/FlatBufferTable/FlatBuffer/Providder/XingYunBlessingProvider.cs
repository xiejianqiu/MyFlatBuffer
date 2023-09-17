using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_XingYunBlessingProvider
    {
        private static FB_XingYunBlessingProvider _Instance;
        public static FB_XingYunBlessingProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_XingYunBlessingProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/XingYunBlessing.txt";
        protected Dictionary<int, FB_XingYunBlessing> mData = new Dictionary<int, FB_XingYunBlessing>();
        private List<FB_XingYunBlessing> mListData = new List<FB_XingYunBlessing>();
        public List<FB_XingYunBlessing> ListData
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
        public FB_XingYunBlessing GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_XingYunBlessing);
        }
        public Dictionary<int, FB_XingYunBlessing> GetData()
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
            if (!FB_XingYunBlessingContainer.FB_XingYunBlessingContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_XingYunBlessingContainer.GetRootAsFB_XingYunBlessingContainer(bb);
            for (int index = 0; index < data.ItemsLength; index++)
            {
                var item = data.GetItems(index);
                mData.Add(item.EventId, item);
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
