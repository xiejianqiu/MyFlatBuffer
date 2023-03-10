using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_GuildBaseProvider
    {
        private static FB_GuildBaseProvider _Instance;
        public static FB_GuildBaseProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_GuildBaseProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/GuildBase.txt";
        protected Dictionary<int, FB_GuildBase> mData = new Dictionary<int, FB_GuildBase>();
        private List<FB_GuildBase> mListData = new List<FB_GuildBase>();
        public List<FB_GuildBase> ListData
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
        public FB_GuildBase GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_GuildBase);
        }
        public Dictionary<int, FB_GuildBase> GetData()
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
            if (!FB_GuildBaseContainer.FB_GuildBaseContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_GuildBaseContainer.GetRootAsFB_GuildBaseContainer(bb);
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
