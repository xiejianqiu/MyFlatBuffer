using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_ChangeJob8ComprehendUpProvider
    {
        private static FB_ChangeJob8ComprehendUpProvider _Instance;
        public static FB_ChangeJob8ComprehendUpProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_ChangeJob8ComprehendUpProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/ChangeJob8ComprehendUp.txt";
        protected Dictionary<int, FB_ChangeJob8ComprehendUp> mData = new Dictionary<int, FB_ChangeJob8ComprehendUp>();
        private List<FB_ChangeJob8ComprehendUp> mListData = new List<FB_ChangeJob8ComprehendUp>();
        public List<FB_ChangeJob8ComprehendUp> ListData
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
        public FB_ChangeJob8ComprehendUp GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_ChangeJob8ComprehendUp);
        }
        public Dictionary<int, FB_ChangeJob8ComprehendUp> GetData()
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
            if (!FB_ChangeJob8ComprehendUpContainer.FB_ChangeJob8ComprehendUpContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_ChangeJob8ComprehendUpContainer.GetRootAsFB_ChangeJob8ComprehendUpContainer(bb);
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
