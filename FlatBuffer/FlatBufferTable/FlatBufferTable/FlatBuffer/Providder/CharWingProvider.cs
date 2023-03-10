using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_CharWingProvider
    {
        private static FB_CharWingProvider _Instance;
        public static FB_CharWingProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_CharWingProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Client/CharWing.txt";
        protected Dictionary<int, FB_CharWing> mData = new Dictionary<int, FB_CharWing>();
        private List<FB_CharWing> mListData = new List<FB_CharWing>();
        public List<FB_CharWing> ListData
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
        public FB_CharWing GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_CharWing);
        }
        public Dictionary<int, FB_CharWing> GetData()
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
            if (!FB_CharWingContainer.FB_CharWingContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_CharWingContainer.GetRootAsFB_CharWingContainer(bb);
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
