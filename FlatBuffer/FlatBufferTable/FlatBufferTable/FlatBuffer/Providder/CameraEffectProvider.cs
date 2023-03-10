using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_CameraEffectProvider
    {
        private static FB_CameraEffectProvider _Instance;
        public static FB_CameraEffectProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_CameraEffectProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Client/CameraEffect.txt";
        protected Dictionary<int, FB_CameraEffect> mData = new Dictionary<int, FB_CameraEffect>();
        private List<FB_CameraEffect> mListData = new List<FB_CameraEffect>();
        public List<FB_CameraEffect> ListData
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
        public FB_CameraEffect GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_CameraEffect);
        }
        public Dictionary<int, FB_CameraEffect> GetData()
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
            if (!FB_CameraEffectContainer.FB_CameraEffectContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_CameraEffectContainer.GetRootAsFB_CameraEffectContainer(bb);
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
