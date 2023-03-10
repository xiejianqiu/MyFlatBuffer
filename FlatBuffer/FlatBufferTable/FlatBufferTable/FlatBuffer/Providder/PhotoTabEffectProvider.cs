using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_PhotoTabEffectProvider
    {
        private static FB_PhotoTabEffectProvider _Instance;
        public static FB_PhotoTabEffectProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_PhotoTabEffectProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Client/PhotoTabEffect.txt";
        protected Dictionary<int, FB_PhotoTabEffect> mData = new Dictionary<int, FB_PhotoTabEffect>();
        private List<FB_PhotoTabEffect> mListData = new List<FB_PhotoTabEffect>();
        public List<FB_PhotoTabEffect> ListData
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
        public FB_PhotoTabEffect GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_PhotoTabEffect);
        }
        public Dictionary<int, FB_PhotoTabEffect> GetData()
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
            if (!FB_PhotoTabEffectContainer.FB_PhotoTabEffectContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_PhotoTabEffectContainer.GetRootAsFB_PhotoTabEffectContainer(bb);
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