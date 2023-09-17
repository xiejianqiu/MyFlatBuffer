using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_EmotionClassProvider
    {
        private static FB_EmotionClassProvider _Instance;
        public static FB_EmotionClassProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_EmotionClassProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/EmotionClass.txt";
        protected Dictionary<int, FB_EmotionClass> mData = new Dictionary<int, FB_EmotionClass>();
        private List<FB_EmotionClass> mListData = new List<FB_EmotionClass>();
        public List<FB_EmotionClass> ListData
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
        public FB_EmotionClass GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_EmotionClass);
        }
        public Dictionary<int, FB_EmotionClass> GetData()
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
            if (!FB_EmotionClassContainer.FB_EmotionClassContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_EmotionClassContainer.GetRootAsFB_EmotionClassContainer(bb);
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
