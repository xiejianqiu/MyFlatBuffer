using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_LingGangStepBaseProvider
    {
        private static FB_LingGangStepBaseProvider _Instance;
        public static FB_LingGangStepBaseProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_LingGangStepBaseProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/LingGangStepBase.txt";
        protected Dictionary<int, FB_LingGangStepBase> mData = new Dictionary<int, FB_LingGangStepBase>();
        private List<FB_LingGangStepBase> mListData = new List<FB_LingGangStepBase>();
        public List<FB_LingGangStepBase> ListData
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
        public FB_LingGangStepBase GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_LingGangStepBase);
        }
        public Dictionary<int, FB_LingGangStepBase> GetData()
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
            if (!FB_LingGangStepBaseContainer.FB_LingGangStepBaseContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_LingGangStepBaseContainer.GetRootAsFB_LingGangStepBaseContainer(bb);
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
