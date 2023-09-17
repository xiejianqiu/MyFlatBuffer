using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_NPCPaoPaoProvider
    {
        private static FB_NPCPaoPaoProvider _Instance;
        public static FB_NPCPaoPaoProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_NPCPaoPaoProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Client/NPCPaoPao.txt";
        protected Dictionary<int, FB_NPCPaoPao> mData = new Dictionary<int, FB_NPCPaoPao>();
        private List<FB_NPCPaoPao> mListData = new List<FB_NPCPaoPao>();
        public List<FB_NPCPaoPao> ListData
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
        public FB_NPCPaoPao GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_NPCPaoPao);
        }
        public Dictionary<int, FB_NPCPaoPao> GetData()
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
            if (!FB_NPCPaoPaoContainer.FB_NPCPaoPaoContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_NPCPaoPaoContainer.GetRootAsFB_NPCPaoPaoContainer(bb);
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
