using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_EmotionBaseProvider
    {
        private static FB_EmotionBaseProvider _Instance;
        public static FB_EmotionBaseProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_EmotionBaseProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/EmotionBase.txt";
        protected Dictionary<int, FB_EmotionBase> mData = new Dictionary<int, FB_EmotionBase>();
        private List<FB_EmotionBase> mListData = new List<FB_EmotionBase>();
        public List<FB_EmotionBase> ListData
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
        public FB_EmotionBase GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_EmotionBase);
        }
        public Dictionary<int, FB_EmotionBase> GetData()
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
            if (!FB_EmotionBaseContainer.FB_EmotionBaseContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_EmotionBaseContainer.GetRootAsFB_EmotionBaseContainer(bb);
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
