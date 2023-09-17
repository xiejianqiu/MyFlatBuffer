using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_BattlefieldCampRewProvider
    {
        private static FB_BattlefieldCampRewProvider _Instance;
        public static FB_BattlefieldCampRewProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_BattlefieldCampRewProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/BattlefieldCampRew.txt";
        protected Dictionary<int, FB_BattlefieldCampRew> mData = new Dictionary<int, FB_BattlefieldCampRew>();
        private List<FB_BattlefieldCampRew> mListData = new List<FB_BattlefieldCampRew>();
        public List<FB_BattlefieldCampRew> ListData
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
        public FB_BattlefieldCampRew GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_BattlefieldCampRew);
        }
        public Dictionary<int, FB_BattlefieldCampRew> GetData()
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
            if (!FB_BattlefieldCampRewContainer.FB_BattlefieldCampRewContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_BattlefieldCampRewContainer.GetRootAsFB_BattlefieldCampRewContainer(bb);
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
