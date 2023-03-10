using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_StoryPlayerEffectProvider
    {
        private static FB_StoryPlayerEffectProvider _Instance;
        public static FB_StoryPlayerEffectProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_StoryPlayerEffectProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Client/StoryPlayerEffect.txt";
        protected Dictionary<int, FB_StoryPlayerEffect> mData = new Dictionary<int, FB_StoryPlayerEffect>();
        private List<FB_StoryPlayerEffect> mListData = new List<FB_StoryPlayerEffect>();
        public List<FB_StoryPlayerEffect> ListData
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
        public FB_StoryPlayerEffect GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_StoryPlayerEffect);
        }
        public Dictionary<int, FB_StoryPlayerEffect> GetData()
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
            if (!FB_StoryPlayerEffectContainer.FB_StoryPlayerEffectContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_StoryPlayerEffectContainer.GetRootAsFB_StoryPlayerEffectContainer(bb);
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
