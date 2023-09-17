using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_EffectProvider
    {
        private static FB_EffectProvider _Instance;
        public static FB_EffectProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_EffectProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Client/Effect.txt";
        protected Dictionary<int, FB_Effect> mData = new Dictionary<int, FB_Effect>();
        private List<FB_Effect> mListData = new List<FB_Effect>();
        public List<FB_Effect> ListData
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
        public FB_Effect GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_Effect);
        }
        public Dictionary<int, FB_Effect> GetData()
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
            if (!FB_EffectContainer.FB_EffectContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_EffectContainer.GetRootAsFB_EffectContainer(bb);
            for (int index = 0; index < data.ItemsLength; index++)
            {
                var item = data.GetItems(index);
                mData.Add(item.EffectID, item);
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
