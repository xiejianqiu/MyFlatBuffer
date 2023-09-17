using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_SexDistinctionProvider
    {
        private static FB_SexDistinctionProvider _Instance;
        public static FB_SexDistinctionProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_SexDistinctionProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Client/SexDistinction.txt";
        protected Dictionary<int, FB_SexDistinction> mData = new Dictionary<int, FB_SexDistinction>();
        private List<FB_SexDistinction> mListData = new List<FB_SexDistinction>();
        public List<FB_SexDistinction> ListData
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
        public FB_SexDistinction GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_SexDistinction);
        }
        public Dictionary<int, FB_SexDistinction> GetData()
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
            if (!FB_SexDistinctionContainer.FB_SexDistinctionContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_SexDistinctionContainer.GetRootAsFB_SexDistinctionContainer(bb);
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
