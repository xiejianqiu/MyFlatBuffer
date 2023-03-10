using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_XingYuTicketBonusProvider
    {
        private static FB_XingYuTicketBonusProvider _Instance;
        public static FB_XingYuTicketBonusProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_XingYuTicketBonusProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/XingYuTicketBonus.txt";
        protected Dictionary<int, FB_XingYuTicketBonus> mData = new Dictionary<int, FB_XingYuTicketBonus>();
        private List<FB_XingYuTicketBonus> mListData = new List<FB_XingYuTicketBonus>();
        public List<FB_XingYuTicketBonus> ListData
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
        public FB_XingYuTicketBonus GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_XingYuTicketBonus);
        }
        public Dictionary<int, FB_XingYuTicketBonus> GetData()
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
            if (!FB_XingYuTicketBonusContainer.FB_XingYuTicketBonusContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_XingYuTicketBonusContainer.GetRootAsFB_XingYuTicketBonusContainer(bb);
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
