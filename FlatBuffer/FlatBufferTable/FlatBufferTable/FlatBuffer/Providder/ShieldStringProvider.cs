using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_ShieldStringProvider
    {
        private static FB_ShieldStringProvider _Instance;
        public static FB_ShieldStringProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_ShieldStringProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Client/ShieldString.txt";
        protected Dictionary<int, FB_ShieldString> mData = new Dictionary<int, FB_ShieldString>();
        private List<FB_ShieldString> mListData = new List<FB_ShieldString>();
        public List<FB_ShieldString> ListData
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
        public FB_ShieldString GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_ShieldString);
        }
        public Dictionary<int, FB_ShieldString> GetData()
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
            if (!FB_ShieldStringContainer.FB_ShieldStringContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_ShieldStringContainer.GetRootAsFB_ShieldStringContainer(bb);
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
