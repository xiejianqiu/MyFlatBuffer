using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_MissionDictionaryProvider
    {
        private static FB_MissionDictionaryProvider _Instance;
        public static FB_MissionDictionaryProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_MissionDictionaryProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Client/MissionDictionary.txt";
        protected Dictionary<int, FB_MissionDictionary> mData = new Dictionary<int, FB_MissionDictionary>();
        private List<FB_MissionDictionary> mListData = new List<FB_MissionDictionary>();
        public List<FB_MissionDictionary> ListData
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
        public FB_MissionDictionary GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_MissionDictionary);
        }
        public Dictionary<int, FB_MissionDictionary> GetData()
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
            if (!FB_MissionDictionaryContainer.FB_MissionDictionaryContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_MissionDictionaryContainer.GetRootAsFB_MissionDictionaryContainer(bb);
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
