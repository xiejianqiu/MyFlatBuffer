using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_OldGodUnitBaseProvider
    {
        private static FB_OldGodUnitBaseProvider _Instance;
        public static FB_OldGodUnitBaseProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_OldGodUnitBaseProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/OldGodUnitBase.txt";
        protected Dictionary<int, FB_OldGodUnitBase> mData = new Dictionary<int, FB_OldGodUnitBase>();
        private List<FB_OldGodUnitBase> mListData = new List<FB_OldGodUnitBase>();
        public List<FB_OldGodUnitBase> ListData
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
        public FB_OldGodUnitBase GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_OldGodUnitBase);
        }
        public Dictionary<int, FB_OldGodUnitBase> GetData()
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
            if (!FB_OldGodUnitBaseContainer.FB_OldGodUnitBaseContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_OldGodUnitBaseContainer.GetRootAsFB_OldGodUnitBaseContainer(bb);
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
