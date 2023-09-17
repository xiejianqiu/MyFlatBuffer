using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_MondayLuckDrawMissionsProvider
    {
        private static FB_MondayLuckDrawMissionsProvider _Instance;
        public static FB_MondayLuckDrawMissionsProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_MondayLuckDrawMissionsProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/MondayLuckDrawMissions.txt";
        protected Dictionary<int, FB_MondayLuckDrawMissions> mData = new Dictionary<int, FB_MondayLuckDrawMissions>();
        private List<FB_MondayLuckDrawMissions> mListData = new List<FB_MondayLuckDrawMissions>();
        public List<FB_MondayLuckDrawMissions> ListData
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
        public FB_MondayLuckDrawMissions GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_MondayLuckDrawMissions);
        }
        public Dictionary<int, FB_MondayLuckDrawMissions> GetData()
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
            if (!FB_MondayLuckDrawMissionsContainer.FB_MondayLuckDrawMissionsContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_MondayLuckDrawMissionsContainer.GetRootAsFB_MondayLuckDrawMissionsContainer(bb);
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
