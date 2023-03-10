using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_GuideTypeProvider
    {
        private static FB_GuideTypeProvider _Instance;
        public static FB_GuideTypeProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_GuideTypeProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Client/GuideType.txt";
        protected Dictionary<int, FB_GuideType> mData = new Dictionary<int, FB_GuideType>();
        private List<FB_GuideType> mListData = new List<FB_GuideType>();
        public List<FB_GuideType> ListData
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
        public FB_GuideType GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_GuideType);
        }
        public Dictionary<int, FB_GuideType> GetData()
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
            if (!FB_GuideTypeContainer.FB_GuideTypeContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_GuideTypeContainer.GetRootAsFB_GuideTypeContainer(bb);
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
