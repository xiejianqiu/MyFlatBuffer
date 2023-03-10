using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_GuildFormationBaseProvider
    {
        private static FB_GuildFormationBaseProvider _Instance;
        public static FB_GuildFormationBaseProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_GuildFormationBaseProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/GuildFormationBase.txt";
        protected Dictionary<int, FB_GuildFormationBase> mData = new Dictionary<int, FB_GuildFormationBase>();
        private List<FB_GuildFormationBase> mListData = new List<FB_GuildFormationBase>();
        public List<FB_GuildFormationBase> ListData
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
        public FB_GuildFormationBase GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_GuildFormationBase);
        }
        public Dictionary<int, FB_GuildFormationBase> GetData()
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
            if (!FB_GuildFormationBaseContainer.FB_GuildFormationBaseContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_GuildFormationBaseContainer.GetRootAsFB_GuildFormationBaseContainer(bb);
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
