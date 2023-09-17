using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_BattlefieldCollectionRewProvider
    {
        private static FB_BattlefieldCollectionRewProvider _Instance;
        public static FB_BattlefieldCollectionRewProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_BattlefieldCollectionRewProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/BattlefieldCollectionRew.txt";
        protected Dictionary<int, FB_BattlefieldCollectionRew> mData = new Dictionary<int, FB_BattlefieldCollectionRew>();
        private List<FB_BattlefieldCollectionRew> mListData = new List<FB_BattlefieldCollectionRew>();
        public List<FB_BattlefieldCollectionRew> ListData
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
        public FB_BattlefieldCollectionRew GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_BattlefieldCollectionRew);
        }
        public Dictionary<int, FB_BattlefieldCollectionRew> GetData()
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
            if (!FB_BattlefieldCollectionRewContainer.FB_BattlefieldCollectionRewContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_BattlefieldCollectionRewContainer.GetRootAsFB_BattlefieldCollectionRewContainer(bb);
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
