using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_RoleBaseAttrProvider
    {
        private static FB_RoleBaseAttrProvider _Instance;
        public static FB_RoleBaseAttrProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_RoleBaseAttrProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/RoleBaseAttr.txt";
        protected Dictionary<int, FB_RoleBaseAttr> mData = new Dictionary<int, FB_RoleBaseAttr>();
        private List<FB_RoleBaseAttr> mListData = new List<FB_RoleBaseAttr>();
        public List<FB_RoleBaseAttr> ListData
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
        public FB_RoleBaseAttr GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_RoleBaseAttr);
        }
        public Dictionary<int, FB_RoleBaseAttr> GetData()
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
            if (!FB_RoleBaseAttrContainer.FB_RoleBaseAttrContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_RoleBaseAttrContainer.GetRootAsFB_RoleBaseAttrContainer(bb);
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
