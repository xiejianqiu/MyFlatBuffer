using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_GuildRedPacketProvider
    {
        private static FB_GuildRedPacketProvider _Instance;
        public static FB_GuildRedPacketProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_GuildRedPacketProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/GuildRedPacket.txt";
        protected Dictionary<int, FB_GuildRedPacket> mData = new Dictionary<int, FB_GuildRedPacket>();
        private List<FB_GuildRedPacket> mListData = new List<FB_GuildRedPacket>();
        public List<FB_GuildRedPacket> ListData
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
        public FB_GuildRedPacket GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_GuildRedPacket);
        }
        public Dictionary<int, FB_GuildRedPacket> GetData()
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
            if (!FB_GuildRedPacketContainer.FB_GuildRedPacketContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_GuildRedPacketContainer.GetRootAsFB_GuildRedPacketContainer(bb);
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
