using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_XingHunZhuanJingEffectProvider
    {
        private static FB_XingHunZhuanJingEffectProvider _Instance;
        public static FB_XingHunZhuanJingEffectProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_XingHunZhuanJingEffectProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/XingHunZhuanJingEffect.txt";
        protected Dictionary<int, FB_XingHunZhuanJingEffect> mData = new Dictionary<int, FB_XingHunZhuanJingEffect>();
        private List<FB_XingHunZhuanJingEffect> mListData = new List<FB_XingHunZhuanJingEffect>();
        public List<FB_XingHunZhuanJingEffect> ListData
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
        public FB_XingHunZhuanJingEffect GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_XingHunZhuanJingEffect);
        }
        public Dictionary<int, FB_XingHunZhuanJingEffect> GetData()
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
            if (!FB_XingHunZhuanJingEffectContainer.FB_XingHunZhuanJingEffectContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_XingHunZhuanJingEffectContainer.GetRootAsFB_XingHunZhuanJingEffectContainer(bb);
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
