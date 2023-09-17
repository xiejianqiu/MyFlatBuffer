using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_GuildPresentProvider
    {
        private static FB_GuildPresentProvider _Instance;
        public static FB_GuildPresentProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_GuildPresentProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/GuildPresent.txt";
        protected Dictionary<int, FB_GuildPresent> mData = new Dictionary<int, FB_GuildPresent>();
        private List<FB_GuildPresent> mListData = new List<FB_GuildPresent>();
        public List<FB_GuildPresent> ListData
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
        public FB_GuildPresent GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_GuildPresent);
        }
        public Dictionary<int, FB_GuildPresent> GetData()
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
            if (!FB_GuildPresentContainer.FB_GuildPresentContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_GuildPresentContainer.GetRootAsFB_GuildPresentContainer(bb);
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
