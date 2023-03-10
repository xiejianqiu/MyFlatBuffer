using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_PhotoEffectProvider
    {
        private static FB_PhotoEffectProvider _Instance;
        public static FB_PhotoEffectProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_PhotoEffectProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Client/PhotoEffect.txt";
        protected Dictionary<int, FB_PhotoEffect> mData = new Dictionary<int, FB_PhotoEffect>();
        private List<FB_PhotoEffect> mListData = new List<FB_PhotoEffect>();
        public List<FB_PhotoEffect> ListData
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
        public FB_PhotoEffect GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_PhotoEffect);
        }
        public Dictionary<int, FB_PhotoEffect> GetData()
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
            if (!FB_PhotoEffectContainer.FB_PhotoEffectContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_PhotoEffectContainer.GetRootAsFB_PhotoEffectContainer(bb);
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
