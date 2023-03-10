using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_YuanShenShowExpProvider
    {
        private static FB_YuanShenShowExpProvider _Instance;
        public static FB_YuanShenShowExpProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_YuanShenShowExpProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/YuanShenShowExp.txt";
        protected Dictionary<int, FB_YuanShenShowExp> mData = new Dictionary<int, FB_YuanShenShowExp>();
        private List<FB_YuanShenShowExp> mListData = new List<FB_YuanShenShowExp>();
        public List<FB_YuanShenShowExp> ListData
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
        public FB_YuanShenShowExp GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_YuanShenShowExp);
        }
        public Dictionary<int, FB_YuanShenShowExp> GetData()
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
            if (!FB_YuanShenShowExpContainer.FB_YuanShenShowExpContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_YuanShenShowExpContainer.GetRootAsFB_YuanShenShowExpContainer(bb);
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
