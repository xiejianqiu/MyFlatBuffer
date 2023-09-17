using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_NpcDialogProvider
    {
        private static FB_NpcDialogProvider _Instance;
        public static FB_NpcDialogProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_NpcDialogProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/NpcDialog.txt";
        protected Dictionary<int, FB_NpcDialog> mData = new Dictionary<int, FB_NpcDialog>();
        private List<FB_NpcDialog> mListData = new List<FB_NpcDialog>();
        public List<FB_NpcDialog> ListData
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
        public FB_NpcDialog GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_NpcDialog);
        }
        public Dictionary<int, FB_NpcDialog> GetData()
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
            if (!FB_NpcDialogContainer.FB_NpcDialogContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_NpcDialogContainer.GetRootAsFB_NpcDialogContainer(bb);
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
