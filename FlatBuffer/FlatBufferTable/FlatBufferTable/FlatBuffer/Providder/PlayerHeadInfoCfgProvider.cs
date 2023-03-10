using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_PlayerHeadInfoCfgProvider
    {
        private static FB_PlayerHeadInfoCfgProvider _Instance;
        public static FB_PlayerHeadInfoCfgProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_PlayerHeadInfoCfgProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Client/PlayerHeadInfoCfg.txt";
        protected Dictionary<int, FB_PlayerHeadInfoCfg> mData = new Dictionary<int, FB_PlayerHeadInfoCfg>();
        private List<FB_PlayerHeadInfoCfg> mListData = new List<FB_PlayerHeadInfoCfg>();
        public List<FB_PlayerHeadInfoCfg> ListData
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
        public FB_PlayerHeadInfoCfg GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_PlayerHeadInfoCfg);
        }
        public Dictionary<int, FB_PlayerHeadInfoCfg> GetData()
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
            if (!FB_PlayerHeadInfoCfgContainer.FB_PlayerHeadInfoCfgContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_PlayerHeadInfoCfgContainer.GetRootAsFB_PlayerHeadInfoCfgContainer(bb);
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
