using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_OperateResultTipsProvider
    {
        private static FB_OperateResultTipsProvider _Instance;
        public static FB_OperateResultTipsProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_OperateResultTipsProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Client/OperateResultTips.txt";
        protected Dictionary<int, FB_OperateResultTips> mData = new Dictionary<int, FB_OperateResultTips>();
        private List<FB_OperateResultTips> mListData = new List<FB_OperateResultTips>();
        public List<FB_OperateResultTips> ListData
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
        public FB_OperateResultTips GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_OperateResultTips);
        }
        public Dictionary<int, FB_OperateResultTips> GetData()
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
            if (!FB_OperateResultTipsContainer.FB_OperateResultTipsContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_OperateResultTipsContainer.GetRootAsFB_OperateResultTipsContainer(bb);
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
