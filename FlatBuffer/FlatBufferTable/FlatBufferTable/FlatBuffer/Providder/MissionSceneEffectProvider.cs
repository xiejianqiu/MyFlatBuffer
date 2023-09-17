using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_MissionSceneEffectProvider
    {
        private static FB_MissionSceneEffectProvider _Instance;
        public static FB_MissionSceneEffectProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_MissionSceneEffectProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Client/MissionSceneEffect.txt";
        protected Dictionary<int, FB_MissionSceneEffect> mData = new Dictionary<int, FB_MissionSceneEffect>();
        private List<FB_MissionSceneEffect> mListData = new List<FB_MissionSceneEffect>();
        public List<FB_MissionSceneEffect> ListData
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
        public FB_MissionSceneEffect GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_MissionSceneEffect);
        }
        public Dictionary<int, FB_MissionSceneEffect> GetData()
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
            if (!FB_MissionSceneEffectContainer.FB_MissionSceneEffectContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_MissionSceneEffectContainer.GetRootAsFB_MissionSceneEffectContainer(bb);
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
