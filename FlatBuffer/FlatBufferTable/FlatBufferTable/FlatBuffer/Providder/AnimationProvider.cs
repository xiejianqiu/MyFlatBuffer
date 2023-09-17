using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_AnimationProvider
    {
        private static FB_AnimationProvider _Instance;
        public static FB_AnimationProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_AnimationProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Client/Animation.txt";
        protected Dictionary<int, FB_Animation> mData = new Dictionary<int, FB_Animation>();
        private List<FB_Animation> mListData = new List<FB_Animation>();
        public List<FB_Animation> ListData
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
        public FB_Animation GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_Animation);
        }
        public Dictionary<int, FB_Animation> GetData()
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
            if (!FB_AnimationContainer.FB_AnimationContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_AnimationContainer.GetRootAsFB_AnimationContainer(bb);
            for (int index = 0; index < data.ItemsLength; index++)
            {
                var item = data.GetItems(index);
                mData.Add(item.AnimID, item);
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
