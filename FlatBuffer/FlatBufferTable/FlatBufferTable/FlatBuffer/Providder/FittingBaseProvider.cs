using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_FittingBaseProvider
    {
        private static FB_FittingBaseProvider _Instance;
        public static FB_FittingBaseProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_FittingBaseProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Client/FittingBase.txt";
        protected Dictionary<int, FB_FittingBase> mData = new Dictionary<int, FB_FittingBase>();
        private List<FB_FittingBase> mListData = new List<FB_FittingBase>();
        public List<FB_FittingBase> ListData
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
        public FB_FittingBase GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_FittingBase);
        }
        public Dictionary<int, FB_FittingBase> GetData()
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
            if (!FB_FittingBaseContainer.FB_FittingBaseContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_FittingBaseContainer.GetRootAsFB_FittingBaseContainer(bb);
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
