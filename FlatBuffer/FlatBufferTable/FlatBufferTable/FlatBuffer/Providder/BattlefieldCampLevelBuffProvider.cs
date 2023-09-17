using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_BattlefieldCampLevelBuffProvider
    {
        private static FB_BattlefieldCampLevelBuffProvider _Instance;
        public static FB_BattlefieldCampLevelBuffProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_BattlefieldCampLevelBuffProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/BattlefieldCampLevelBuff.txt";
        protected Dictionary<int, FB_BattlefieldCampLevelBuff> mData = new Dictionary<int, FB_BattlefieldCampLevelBuff>();
        private List<FB_BattlefieldCampLevelBuff> mListData = new List<FB_BattlefieldCampLevelBuff>();
        public List<FB_BattlefieldCampLevelBuff> ListData
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
        public FB_BattlefieldCampLevelBuff GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_BattlefieldCampLevelBuff);
        }
        public Dictionary<int, FB_BattlefieldCampLevelBuff> GetData()
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
            if (!FB_BattlefieldCampLevelBuffContainer.FB_BattlefieldCampLevelBuffContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_BattlefieldCampLevelBuffContainer.GetRootAsFB_BattlefieldCampLevelBuffContainer(bb);
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
