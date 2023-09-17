using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_CharModelProvider
    {
        private static FB_CharModelProvider _Instance;
        public static FB_CharModelProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_CharModelProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Client/CharModel.txt";
        protected Dictionary<int, FB_CharModel> mData = new Dictionary<int, FB_CharModel>();
        private List<FB_CharModel> mListData = new List<FB_CharModel>();
        public List<FB_CharModel> ListData
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
        public FB_CharModel GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_CharModel);
        }
        public Dictionary<int, FB_CharModel> GetData()
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
            if (!FB_CharModelContainer.FB_CharModelContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_CharModelContainer.GetRootAsFB_CharModelContainer(bb);
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
