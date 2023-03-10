using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_CoolDownTimeProvider
    {
        private static FB_CoolDownTimeProvider _Instance;
        public static FB_CoolDownTimeProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_CoolDownTimeProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/CoolDownTime.txt";
        protected Dictionary<int, FB_CoolDownTime> mData = new Dictionary<int, FB_CoolDownTime>();
        private List<FB_CoolDownTime> mListData = new List<FB_CoolDownTime>();
        public List<FB_CoolDownTime> ListData
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
        public FB_CoolDownTime GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_CoolDownTime);
        }
        public Dictionary<int, FB_CoolDownTime> GetData()
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
            if (!FB_CoolDownTimeContainer.FB_CoolDownTimeContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_CoolDownTimeContainer.GetRootAsFB_CoolDownTimeContainer(bb);
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
