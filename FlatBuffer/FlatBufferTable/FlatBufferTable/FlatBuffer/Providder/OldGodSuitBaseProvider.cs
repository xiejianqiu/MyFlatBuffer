using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_OldGodSuitBaseProvider
    {
        private static FB_OldGodSuitBaseProvider _Instance;
        public static FB_OldGodSuitBaseProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_OldGodSuitBaseProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/OldGodSuitBase.txt";
        protected Dictionary<int, FB_OldGodSuitBase> mData = new Dictionary<int, FB_OldGodSuitBase>();
        private List<FB_OldGodSuitBase> mListData = new List<FB_OldGodSuitBase>();
        public List<FB_OldGodSuitBase> ListData
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
        public FB_OldGodSuitBase GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_OldGodSuitBase);
        }
        public Dictionary<int, FB_OldGodSuitBase> GetData()
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
            if (!FB_OldGodSuitBaseContainer.FB_OldGodSuitBaseContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_OldGodSuitBaseContainer.GetRootAsFB_OldGodSuitBaseContainer(bb);
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
