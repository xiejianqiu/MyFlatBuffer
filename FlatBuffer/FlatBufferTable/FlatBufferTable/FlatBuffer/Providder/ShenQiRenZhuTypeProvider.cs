using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_ShenQiRenZhuTypeProvider
    {
        private static FB_ShenQiRenZhuTypeProvider _Instance;
        public static FB_ShenQiRenZhuTypeProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_ShenQiRenZhuTypeProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/ShenQiRenZhuType.txt";
        protected Dictionary<int, FB_ShenQiRenZhuType> mData = new Dictionary<int, FB_ShenQiRenZhuType>();
        private List<FB_ShenQiRenZhuType> mListData = new List<FB_ShenQiRenZhuType>();
        public List<FB_ShenQiRenZhuType> ListData
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
        public FB_ShenQiRenZhuType GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_ShenQiRenZhuType);
        }
        public Dictionary<int, FB_ShenQiRenZhuType> GetData()
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
            if (!FB_ShenQiRenZhuTypeContainer.FB_ShenQiRenZhuTypeContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_ShenQiRenZhuTypeContainer.GetRootAsFB_ShenQiRenZhuTypeContainer(bb);
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
