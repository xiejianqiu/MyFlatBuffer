using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_GuildBossProvider
    {
        private static FB_GuildBossProvider _Instance;
        public static FB_GuildBossProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_GuildBossProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/GuildBoss.txt";
        protected Dictionary<int, FB_GuildBoss> mData = new Dictionary<int, FB_GuildBoss>();
        private List<FB_GuildBoss> mListData = new List<FB_GuildBoss>();
        public List<FB_GuildBoss> ListData
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
        public FB_GuildBoss GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_GuildBoss);
        }
        public Dictionary<int, FB_GuildBoss> GetData()
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
            if (!FB_GuildBossContainer.FB_GuildBossContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_GuildBossContainer.GetRootAsFB_GuildBossContainer(bb);
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
