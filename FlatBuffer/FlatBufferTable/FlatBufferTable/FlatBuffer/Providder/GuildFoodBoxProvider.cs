using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_GuildFoodBoxProvider
    {
        private static FB_GuildFoodBoxProvider _Instance;
        public static FB_GuildFoodBoxProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_GuildFoodBoxProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/GuildFoodBox.txt";
        protected Dictionary<int, FB_GuildFoodBox> mData = new Dictionary<int, FB_GuildFoodBox>();
        private List<FB_GuildFoodBox> mListData = new List<FB_GuildFoodBox>();
        public List<FB_GuildFoodBox> ListData
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
        public FB_GuildFoodBox GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_GuildFoodBox);
        }
        public Dictionary<int, FB_GuildFoodBox> GetData()
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
            if (!FB_GuildFoodBoxContainer.FB_GuildFoodBoxContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_GuildFoodBoxContainer.GetRootAsFB_GuildFoodBoxContainer(bb);
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
