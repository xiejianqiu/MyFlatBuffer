using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_GuildFormationTypeProvider
    {
        private static FB_GuildFormationTypeProvider _Instance;
        public static FB_GuildFormationTypeProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_GuildFormationTypeProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Client/GuildFormationType.txt";
        protected Dictionary<int, FB_GuildFormationType> mData = new Dictionary<int, FB_GuildFormationType>();
        private List<FB_GuildFormationType> mListData = new List<FB_GuildFormationType>();
        public List<FB_GuildFormationType> ListData
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
        public FB_GuildFormationType GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_GuildFormationType);
        }
        public Dictionary<int, FB_GuildFormationType> GetData()
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
            if (!FB_GuildFormationTypeContainer.FB_GuildFormationTypeContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_GuildFormationTypeContainer.GetRootAsFB_GuildFormationTypeContainer(bb);
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
