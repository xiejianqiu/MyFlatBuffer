using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_HunJiangSkillValueProvider
    {
        private static FB_HunJiangSkillValueProvider _Instance;
        public static FB_HunJiangSkillValueProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_HunJiangSkillValueProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/HunJiangSkillValue.txt";
        protected Dictionary<int, FB_HunJiangSkillValue> mData = new Dictionary<int, FB_HunJiangSkillValue>();
        private List<FB_HunJiangSkillValue> mListData = new List<FB_HunJiangSkillValue>();
        public List<FB_HunJiangSkillValue> ListData
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
        public FB_HunJiangSkillValue GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_HunJiangSkillValue);
        }
        public Dictionary<int, FB_HunJiangSkillValue> GetData()
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
            if (!FB_HunJiangSkillValueContainer.FB_HunJiangSkillValueContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_HunJiangSkillValueContainer.GetRootAsFB_HunJiangSkillValueContainer(bb);
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
