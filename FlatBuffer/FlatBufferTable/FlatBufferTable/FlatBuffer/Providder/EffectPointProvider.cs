using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_EffectPointProvider
    {
        private static FB_EffectPointProvider _Instance;
        public static FB_EffectPointProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_EffectPointProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Client/EffectPoint.txt";
        protected Dictionary<int, FB_EffectPoint> mData = new Dictionary<int, FB_EffectPoint>();
        private List<FB_EffectPoint> mListData = new List<FB_EffectPoint>();
        public List<FB_EffectPoint> ListData
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
        public FB_EffectPoint GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_EffectPoint);
        }
        public Dictionary<int, FB_EffectPoint> GetData()
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
            if (!FB_EffectPointContainer.FB_EffectPointContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_EffectPointContainer.GetRootAsFB_EffectPointContainer(bb);
            for (int index = 0; index < data.ItemsLength; index++)
            {
                var item = data.GetItems(index);
                mData.Add(item.ModelTypeId, item);
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
