using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_DymaticSceneEffectProvider
    {
        private static FB_DymaticSceneEffectProvider _Instance;
        public static FB_DymaticSceneEffectProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_DymaticSceneEffectProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Client/DymaticSceneEffect.txt";
        protected Dictionary<int, FB_DymaticSceneEffect> mData = new Dictionary<int, FB_DymaticSceneEffect>();
        private List<FB_DymaticSceneEffect> mListData = new List<FB_DymaticSceneEffect>();
        public List<FB_DymaticSceneEffect> ListData
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
        public FB_DymaticSceneEffect GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_DymaticSceneEffect);
        }
        public Dictionary<int, FB_DymaticSceneEffect> GetData()
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
            if (!FB_DymaticSceneEffectContainer.FB_DymaticSceneEffectContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_DymaticSceneEffectContainer.GetRootAsFB_DymaticSceneEffectContainer(bb);
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
