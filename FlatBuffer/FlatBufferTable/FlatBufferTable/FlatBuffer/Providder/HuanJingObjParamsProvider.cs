using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_HuanJingObjParamsProvider
    {
        private static FB_HuanJingObjParamsProvider _Instance;
        public static FB_HuanJingObjParamsProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_HuanJingObjParamsProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Client/HuanJingObjParams.txt";
        protected Dictionary<int, FB_HuanJingObjParams> mData = new Dictionary<int, FB_HuanJingObjParams>();
        private List<FB_HuanJingObjParams> mListData = new List<FB_HuanJingObjParams>();
        public List<FB_HuanJingObjParams> ListData
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
        public FB_HuanJingObjParams GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_HuanJingObjParams);
        }
        public Dictionary<int, FB_HuanJingObjParams> GetData()
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
            if (!FB_HuanJingObjParamsContainer.FB_HuanJingObjParamsContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_HuanJingObjParamsContainer.GetRootAsFB_HuanJingObjParamsContainer(bb);
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
