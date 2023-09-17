using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_ChangeJobBaseProvider
    {
        private static FB_ChangeJobBaseProvider _Instance;
        public static FB_ChangeJobBaseProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_ChangeJobBaseProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/ChangeJobBase.txt";
        protected Dictionary<int, FB_ChangeJobBase> mData = new Dictionary<int, FB_ChangeJobBase>();
        private List<FB_ChangeJobBase> mListData = new List<FB_ChangeJobBase>();
        public List<FB_ChangeJobBase> ListData
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
        public FB_ChangeJobBase GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_ChangeJobBase);
        }
        public Dictionary<int, FB_ChangeJobBase> GetData()
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
            if (!FB_ChangeJobBaseContainer.FB_ChangeJobBaseContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_ChangeJobBaseContainer.GetRootAsFB_ChangeJobBaseContainer(bb);
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
