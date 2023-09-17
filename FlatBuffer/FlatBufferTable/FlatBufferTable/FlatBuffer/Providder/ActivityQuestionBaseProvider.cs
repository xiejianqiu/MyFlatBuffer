using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_ActivityQuestionBaseProvider
    {
        private static FB_ActivityQuestionBaseProvider _Instance;
        public static FB_ActivityQuestionBaseProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_ActivityQuestionBaseProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/ActivityQuestionBase.txt";
        protected Dictionary<int, FB_ActivityQuestionBase> mData = new Dictionary<int, FB_ActivityQuestionBase>();
        private List<FB_ActivityQuestionBase> mListData = new List<FB_ActivityQuestionBase>();
        public List<FB_ActivityQuestionBase> ListData
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
        public FB_ActivityQuestionBase GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_ActivityQuestionBase);
        }
        public Dictionary<int, FB_ActivityQuestionBase> GetData()
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
            if (!FB_ActivityQuestionBaseContainer.FB_ActivityQuestionBaseContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_ActivityQuestionBaseContainer.GetRootAsFB_ActivityQuestionBaseContainer(bb);
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
