using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_CharSoulProvider
    {
        private static FB_CharSoulProvider _Instance;
        public static FB_CharSoulProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_CharSoulProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Client/CharSoul.txt";
        protected Dictionary<int, FB_CharSoul> mData = new Dictionary<int, FB_CharSoul>();
        private List<FB_CharSoul> mListData = new List<FB_CharSoul>();
        public List<FB_CharSoul> ListData
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
        public FB_CharSoul GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_CharSoul);
        }
        public Dictionary<int, FB_CharSoul> GetData()
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
            if (!FB_CharSoulContainer.FB_CharSoulContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_CharSoulContainer.GetRootAsFB_CharSoulContainer(bb);
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
