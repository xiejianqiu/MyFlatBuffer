using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_OldGodItemBaseProvider
    {
        private static FB_OldGodItemBaseProvider _Instance;
        public static FB_OldGodItemBaseProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_OldGodItemBaseProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/OldGodItemBase.txt";
        protected Dictionary<int, FB_OldGodItemBase> mData = new Dictionary<int, FB_OldGodItemBase>();
        private List<FB_OldGodItemBase> mListData = new List<FB_OldGodItemBase>();
        public List<FB_OldGodItemBase> ListData
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
        public FB_OldGodItemBase GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_OldGodItemBase);
        }
        public Dictionary<int, FB_OldGodItemBase> GetData()
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
            if (!FB_OldGodItemBaseContainer.FB_OldGodItemBaseContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_OldGodItemBaseContainer.GetRootAsFB_OldGodItemBaseContainer(bb);
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
