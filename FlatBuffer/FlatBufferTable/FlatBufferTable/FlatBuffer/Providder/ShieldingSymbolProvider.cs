using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_ShieldingSymbolProvider
    {
        private static FB_ShieldingSymbolProvider _Instance;
        public static FB_ShieldingSymbolProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_ShieldingSymbolProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Client/ShieldingSymbol.txt";
        protected Dictionary<int, FB_ShieldingSymbol> mData = new Dictionary<int, FB_ShieldingSymbol>();
        private List<FB_ShieldingSymbol> mListData = new List<FB_ShieldingSymbol>();
        public List<FB_ShieldingSymbol> ListData
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
        public FB_ShieldingSymbol GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_ShieldingSymbol);
        }
        public Dictionary<int, FB_ShieldingSymbol> GetData()
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
            if (!FB_ShieldingSymbolContainer.FB_ShieldingSymbolContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_ShieldingSymbolContainer.GetRootAsFB_ShieldingSymbolContainer(bb);
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
