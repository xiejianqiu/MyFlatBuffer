using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_DamageBoardTypeProvider
    {
        private static FB_DamageBoardTypeProvider _Instance;
        public static FB_DamageBoardTypeProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_DamageBoardTypeProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Client/DamageBoardType.txt";
        protected Dictionary<int, FB_DamageBoardType> mData = new Dictionary<int, FB_DamageBoardType>();
        private List<FB_DamageBoardType> mListData = new List<FB_DamageBoardType>();
        public List<FB_DamageBoardType> ListData
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
        public FB_DamageBoardType GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_DamageBoardType);
        }
        public Dictionary<int, FB_DamageBoardType> GetData()
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
            if (!FB_DamageBoardTypeContainer.FB_DamageBoardTypeContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_DamageBoardTypeContainer.GetRootAsFB_DamageBoardTypeContainer(bb);
            for (int index = 0; index < data.ItemsLength; index++)
            {
                var item = data.GetItems(index);
                mData.Add(item.DamageBoardTypeID, item);
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
