using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_XingHunZhuanJingBaseProvider
    {
        private static FB_XingHunZhuanJingBaseProvider _Instance;
        public static FB_XingHunZhuanJingBaseProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_XingHunZhuanJingBaseProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/XingHunZhuanJingBase.txt";
        protected Dictionary<int, FB_XingHunZhuanJingBase> mData = new Dictionary<int, FB_XingHunZhuanJingBase>();
        private List<FB_XingHunZhuanJingBase> mListData = new List<FB_XingHunZhuanJingBase>();
        public List<FB_XingHunZhuanJingBase> ListData
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
        public FB_XingHunZhuanJingBase GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_XingHunZhuanJingBase);
        }
        public Dictionary<int, FB_XingHunZhuanJingBase> GetData()
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
            if (!FB_XingHunZhuanJingBaseContainer.FB_XingHunZhuanJingBaseContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_XingHunZhuanJingBaseContainer.GetRootAsFB_XingHunZhuanJingBaseContainer(bb);
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
