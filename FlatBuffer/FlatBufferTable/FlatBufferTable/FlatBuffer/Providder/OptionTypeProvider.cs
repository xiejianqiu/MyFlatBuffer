using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_OptionTypeProvider
    {
        private static FB_OptionTypeProvider _Instance;
        public static FB_OptionTypeProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_OptionTypeProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Client/OptionType.txt";
        protected Dictionary<int, FB_OptionType> mData = new Dictionary<int, FB_OptionType>();
        private List<FB_OptionType> mListData = new List<FB_OptionType>();
        public List<FB_OptionType> ListData
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
        public FB_OptionType GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_OptionType);
        }
        public Dictionary<int, FB_OptionType> GetData()
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
            if (!FB_OptionTypeContainer.FB_OptionTypeContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_OptionTypeContainer.GetRootAsFB_OptionTypeContainer(bb);
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
