using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_ChangeJobPhaseProvider
    {
        private static FB_ChangeJobPhaseProvider _Instance;
        public static FB_ChangeJobPhaseProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_ChangeJobPhaseProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/ChangeJobPhase.txt";
        protected Dictionary<int, FB_ChangeJobPhase> mData = new Dictionary<int, FB_ChangeJobPhase>();
        private List<FB_ChangeJobPhase> mListData = new List<FB_ChangeJobPhase>();
        public List<FB_ChangeJobPhase> ListData
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
        public FB_ChangeJobPhase GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_ChangeJobPhase);
        }
        public Dictionary<int, FB_ChangeJobPhase> GetData()
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
            if (!FB_ChangeJobPhaseContainer.FB_ChangeJobPhaseContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_ChangeJobPhaseContainer.GetRootAsFB_ChangeJobPhaseContainer(bb);
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
