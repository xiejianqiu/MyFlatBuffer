using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_GuildPermissionProvider
    {
        private static FB_GuildPermissionProvider _Instance;
        public static FB_GuildPermissionProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_GuildPermissionProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/GuildPermission.txt";
        protected Dictionary<int, FB_GuildPermission> mData = new Dictionary<int, FB_GuildPermission>();
        private List<FB_GuildPermission> mListData = new List<FB_GuildPermission>();
        public List<FB_GuildPermission> ListData
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
        public FB_GuildPermission GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_GuildPermission);
        }
        public Dictionary<int, FB_GuildPermission> GetData()
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
            if (!FB_GuildPermissionContainer.FB_GuildPermissionContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_GuildPermissionContainer.GetRootAsFB_GuildPermissionContainer(bb);
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
