using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_GuildFormationTypeNewProvider
    {
        private static FB_GuildFormationTypeNewProvider _Instance;
        public static FB_GuildFormationTypeNewProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_GuildFormationTypeNewProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/GuildFormationTypeNew.txt";
        protected Dictionary<int, FB_GuildFormationTypeNew> mData = new Dictionary<int, FB_GuildFormationTypeNew>();
        private List<FB_GuildFormationTypeNew> mListData = new List<FB_GuildFormationTypeNew>();
        public List<FB_GuildFormationTypeNew> ListData
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
        public FB_GuildFormationTypeNew GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_GuildFormationTypeNew);
        }
        public Dictionary<int, FB_GuildFormationTypeNew> GetData()
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
            if (!FB_GuildFormationTypeNewContainer.FB_GuildFormationTypeNewContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_GuildFormationTypeNewContainer.GetRootAsFB_GuildFormationTypeNewContainer(bb);
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
