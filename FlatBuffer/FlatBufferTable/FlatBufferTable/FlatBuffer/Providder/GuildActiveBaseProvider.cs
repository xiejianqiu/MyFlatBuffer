using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_GuildActiveBaseProvider
    {
        private static FB_GuildActiveBaseProvider _Instance;
        public static FB_GuildActiveBaseProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_GuildActiveBaseProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/GuildActiveBase.txt";
        protected Dictionary<int, FB_GuildActiveBase> mData = new Dictionary<int, FB_GuildActiveBase>();
        private List<FB_GuildActiveBase> mListData = new List<FB_GuildActiveBase>();
        public List<FB_GuildActiveBase> ListData
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
        public FB_GuildActiveBase GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_GuildActiveBase);
        }
        public Dictionary<int, FB_GuildActiveBase> GetData()
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
            if (!FB_GuildActiveBaseContainer.FB_GuildActiveBaseContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_GuildActiveBaseContainer.GetRootAsFB_GuildActiveBaseContainer(bb);
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
