using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_StrDictionaryProvider
    {
        private static FB_StrDictionaryProvider _Instance;
        public static FB_StrDictionaryProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_StrDictionaryProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Client/StrDictionary.txt";
        protected Dictionary<int, FB_StrDictionary> mData = new Dictionary<int, FB_StrDictionary>();
        private List<FB_StrDictionary> mListData = new List<FB_StrDictionary>();
        public List<FB_StrDictionary> ListData
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
        public FB_StrDictionary GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_StrDictionary);
        }
        public Dictionary<int, FB_StrDictionary> GetData()
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
            if (!FB_StrDictionaryContainer.FB_StrDictionaryContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_StrDictionaryContainer.GetRootAsFB_StrDictionaryContainer(bb);
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
