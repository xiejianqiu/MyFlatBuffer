using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_StoryAnimationProvider
    {
        private static FB_StoryAnimationProvider _Instance;
        public static FB_StoryAnimationProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_StoryAnimationProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Client/StoryAnimation.txt";
        protected Dictionary<int, FB_StoryAnimation> mData = new Dictionary<int, FB_StoryAnimation>();
        private List<FB_StoryAnimation> mListData = new List<FB_StoryAnimation>();
        public List<FB_StoryAnimation> ListData
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
        public FB_StoryAnimation GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_StoryAnimation);
        }
        public Dictionary<int, FB_StoryAnimation> GetData()
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
            if (!FB_StoryAnimationContainer.FB_StoryAnimationContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_StoryAnimationContainer.GetRootAsFB_StoryAnimationContainer(bb);
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
