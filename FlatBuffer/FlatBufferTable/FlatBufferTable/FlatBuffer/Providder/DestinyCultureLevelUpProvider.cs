using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_DestinyCultureLevelUpProvider
    {
        private static FB_DestinyCultureLevelUpProvider _Instance;
        public static FB_DestinyCultureLevelUpProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_DestinyCultureLevelUpProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/DestinyCultureLevelUp.txt";
        protected Dictionary<int, FB_DestinyCultureLevelUp> mData = new Dictionary<int, FB_DestinyCultureLevelUp>();
        private List<FB_DestinyCultureLevelUp> mListData = new List<FB_DestinyCultureLevelUp>();
        public List<FB_DestinyCultureLevelUp> ListData
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
        public FB_DestinyCultureLevelUp GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_DestinyCultureLevelUp);
        }
        public Dictionary<int, FB_DestinyCultureLevelUp> GetData()
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
            if (!FB_DestinyCultureLevelUpContainer.FB_DestinyCultureLevelUpContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_DestinyCultureLevelUpContainer.GetRootAsFB_DestinyCultureLevelUpContainer(bb);
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
