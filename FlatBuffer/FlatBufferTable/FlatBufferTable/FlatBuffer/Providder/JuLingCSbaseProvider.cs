using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_JuLingCSbaseProvider
    {
        private static FB_JuLingCSbaseProvider _Instance;
        public static FB_JuLingCSbaseProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_JuLingCSbaseProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/JuLingCSbase.txt";
        protected Dictionary<int, FB_JuLingCSbase> mData = new Dictionary<int, FB_JuLingCSbase>();
        private List<FB_JuLingCSbase> mListData = new List<FB_JuLingCSbase>();
        public List<FB_JuLingCSbase> ListData
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
        public FB_JuLingCSbase GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_JuLingCSbase);
        }
        public Dictionary<int, FB_JuLingCSbase> GetData()
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
            if (!FB_JuLingCSbaseContainer.FB_JuLingCSbaseContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_JuLingCSbaseContainer.GetRootAsFB_JuLingCSbaseContainer(bb);
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
