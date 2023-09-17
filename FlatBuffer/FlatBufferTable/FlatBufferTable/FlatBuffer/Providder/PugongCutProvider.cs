using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_PugongCutProvider
    {
        private static FB_PugongCutProvider _Instance;
        public static FB_PugongCutProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_PugongCutProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/PugongCut.txt";
        protected Dictionary<int, FB_PugongCut> mData = new Dictionary<int, FB_PugongCut>();
        private List<FB_PugongCut> mListData = new List<FB_PugongCut>();
        public List<FB_PugongCut> ListData
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
        public FB_PugongCut GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_PugongCut);
        }
        public Dictionary<int, FB_PugongCut> GetData()
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
            if (!FB_PugongCutContainer.FB_PugongCutContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_PugongCutContainer.GetRootAsFB_PugongCutContainer(bb);
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
