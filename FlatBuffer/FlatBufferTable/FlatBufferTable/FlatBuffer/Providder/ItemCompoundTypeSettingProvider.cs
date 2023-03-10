using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_ItemCompoundTypeSettingProvider
    {
        private static FB_ItemCompoundTypeSettingProvider _Instance;
        public static FB_ItemCompoundTypeSettingProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_ItemCompoundTypeSettingProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Client/ItemCompoundTypeSetting.txt";
        protected Dictionary<int, FB_ItemCompoundTypeSetting> mData = new Dictionary<int, FB_ItemCompoundTypeSetting>();
        private List<FB_ItemCompoundTypeSetting> mListData = new List<FB_ItemCompoundTypeSetting>();
        public List<FB_ItemCompoundTypeSetting> ListData
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
        public FB_ItemCompoundTypeSetting GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_ItemCompoundTypeSetting);
        }
        public Dictionary<int, FB_ItemCompoundTypeSetting> GetData()
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
            if (!FB_ItemCompoundTypeSettingContainer.FB_ItemCompoundTypeSettingContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_ItemCompoundTypeSettingContainer.GetRootAsFB_ItemCompoundTypeSettingContainer(bb);
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
