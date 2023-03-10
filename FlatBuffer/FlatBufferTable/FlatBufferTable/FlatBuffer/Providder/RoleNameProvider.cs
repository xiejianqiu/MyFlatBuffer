using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_RoleNameProvider
    {
        private static FB_RoleNameProvider _Instance;
        public static FB_RoleNameProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_RoleNameProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Client/RoleName.txt";
        protected Dictionary<int, FB_RoleName> mData = new Dictionary<int, FB_RoleName>();
        private List<FB_RoleName> mListData = new List<FB_RoleName>();
        public List<FB_RoleName> ListData
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
        public FB_RoleName GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_RoleName);
        }
        public Dictionary<int, FB_RoleName> GetData()
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
            if (!FB_RoleNameContainer.FB_RoleNameContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_RoleNameContainer.GetRootAsFB_RoleNameContainer(bb);
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
