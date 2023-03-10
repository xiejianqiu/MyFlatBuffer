using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_ChangeJob6ItemBaseProvider
    {
        private static FB_ChangeJob6ItemBaseProvider _Instance;
        public static FB_ChangeJob6ItemBaseProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_ChangeJob6ItemBaseProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/ChangeJob6ItemBase.txt";
        protected Dictionary<int, FB_ChangeJob6ItemBase> mData = new Dictionary<int, FB_ChangeJob6ItemBase>();
        private List<FB_ChangeJob6ItemBase> mListData = new List<FB_ChangeJob6ItemBase>();
        public List<FB_ChangeJob6ItemBase> ListData
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
        public FB_ChangeJob6ItemBase GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_ChangeJob6ItemBase);
        }
        public Dictionary<int, FB_ChangeJob6ItemBase> GetData()
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
            if (!FB_ChangeJob6ItemBaseContainer.FB_ChangeJob6ItemBaseContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_ChangeJob6ItemBaseContainer.GetRootAsFB_ChangeJob6ItemBaseContainer(bb);
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