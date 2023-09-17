using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_MissionKillMonsterProvider
    {
        private static FB_MissionKillMonsterProvider _Instance;
        public static FB_MissionKillMonsterProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_MissionKillMonsterProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/MissionKillMonster.txt";
        protected Dictionary<int, FB_MissionKillMonster> mData = new Dictionary<int, FB_MissionKillMonster>();
        private List<FB_MissionKillMonster> mListData = new List<FB_MissionKillMonster>();
        public List<FB_MissionKillMonster> ListData
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
        public FB_MissionKillMonster GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_MissionKillMonster);
        }
        public Dictionary<int, FB_MissionKillMonster> GetData()
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
            if (!FB_MissionKillMonsterContainer.FB_MissionKillMonsterContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_MissionKillMonsterContainer.GetRootAsFB_MissionKillMonsterContainer(bb);
            for (int index = 0; index < data.ItemsLength; index++)
            {
                var item = data.GetItems(index);
                mData.Add(item.Index, item);
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
