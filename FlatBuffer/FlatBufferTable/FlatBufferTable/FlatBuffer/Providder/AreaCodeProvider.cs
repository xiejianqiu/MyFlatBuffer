using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_AreaCodeProvider
    {
        private static FB_AreaCodeProvider _Instance;
        public static FB_AreaCodeProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_AreaCodeProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Client/AreaCode.txt";
        protected Dictionary<int, FB_AreaCode> mData = new Dictionary<int, FB_AreaCode>();
        private List<FB_AreaCode> mListData = new List<FB_AreaCode>();
        public List<FB_AreaCode> ListData
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
        public FB_AreaCode GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_AreaCode);
        }
        public Dictionary<int, FB_AreaCode> GetData()
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
            if (!FB_AreaCodeContainer.FB_AreaCodeContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_AreaCodeContainer.GetRootAsFB_AreaCodeContainer(bb);
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
