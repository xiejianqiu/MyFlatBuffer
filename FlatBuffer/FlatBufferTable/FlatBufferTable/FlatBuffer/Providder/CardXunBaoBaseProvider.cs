using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_CardXunBaoBaseProvider
    {
        private static FB_CardXunBaoBaseProvider _Instance;
        public static FB_CardXunBaoBaseProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_CardXunBaoBaseProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/CardXunBaoBase.txt";
        protected Dictionary<int, FB_CardXunBaoBase> mData = new Dictionary<int, FB_CardXunBaoBase>();
        private List<FB_CardXunBaoBase> mListData = new List<FB_CardXunBaoBase>();
        public List<FB_CardXunBaoBase> ListData
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
        public FB_CardXunBaoBase GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_CardXunBaoBase);
        }
        public Dictionary<int, FB_CardXunBaoBase> GetData()
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
            if (!FB_CardXunBaoBaseContainer.FB_CardXunBaoBaseContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_CardXunBaoBaseContainer.GetRootAsFB_CardXunBaoBaseContainer(bb);
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
