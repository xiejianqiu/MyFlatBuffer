using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_StarCraftTicketProvider
    {
        private static FB_StarCraftTicketProvider _Instance;
        public static FB_StarCraftTicketProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_StarCraftTicketProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/StarCraftTicket.txt";
        protected Dictionary<int, FB_StarCraftTicket> mData = new Dictionary<int, FB_StarCraftTicket>();
        private List<FB_StarCraftTicket> mListData = new List<FB_StarCraftTicket>();
        public List<FB_StarCraftTicket> ListData
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
        public FB_StarCraftTicket GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_StarCraftTicket);
        }
        public Dictionary<int, FB_StarCraftTicket> GetData()
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
            if (!FB_StarCraftTicketContainer.FB_StarCraftTicketContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_StarCraftTicketContainer.GetRootAsFB_StarCraftTicketContainer(bb);
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
