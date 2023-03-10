using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_GuildWelfareBaseProvider
    {
        private static FB_GuildWelfareBaseProvider _Instance;
        public static FB_GuildWelfareBaseProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_GuildWelfareBaseProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/GuildWelfareBase.txt";
        protected Dictionary<int, FB_GuildWelfareBase> mData = new Dictionary<int, FB_GuildWelfareBase>();
        private List<FB_GuildWelfareBase> mListData = new List<FB_GuildWelfareBase>();
        public List<FB_GuildWelfareBase> ListData
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
        public FB_GuildWelfareBase GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_GuildWelfareBase);
        }
        public Dictionary<int, FB_GuildWelfareBase> GetData()
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
            if (!FB_GuildWelfareBaseContainer.FB_GuildWelfareBaseContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_GuildWelfareBaseContainer.GetRootAsFB_GuildWelfareBaseContainer(bb);
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
