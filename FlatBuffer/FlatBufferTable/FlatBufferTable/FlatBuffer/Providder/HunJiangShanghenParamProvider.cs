using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_HunJiangShanghenParamProvider
    {
        private static FB_HunJiangShanghenParamProvider _Instance;
        public static FB_HunJiangShanghenParamProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_HunJiangShanghenParamProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Client/HunJiangShanghenParam.txt";
        protected Dictionary<int, FB_HunJiangShanghenParam> mData = new Dictionary<int, FB_HunJiangShanghenParam>();
        private List<FB_HunJiangShanghenParam> mListData = new List<FB_HunJiangShanghenParam>();
        public List<FB_HunJiangShanghenParam> ListData
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
        public FB_HunJiangShanghenParam GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_HunJiangShanghenParam);
        }
        public Dictionary<int, FB_HunJiangShanghenParam> GetData()
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
            if (!FB_HunJiangShanghenParamContainer.FB_HunJiangShanghenParamContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_HunJiangShanghenParamContainer.GetRootAsFB_HunJiangShanghenParamContainer(bb);
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
