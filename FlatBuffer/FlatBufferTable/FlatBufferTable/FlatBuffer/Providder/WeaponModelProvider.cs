using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_WeaponModelProvider
    {
        private static FB_WeaponModelProvider _Instance;
        public static FB_WeaponModelProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_WeaponModelProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Client/WeaponModel.txt";
        protected Dictionary<int, FB_WeaponModel> mData = new Dictionary<int, FB_WeaponModel>();
        private List<FB_WeaponModel> mListData = new List<FB_WeaponModel>();
        public List<FB_WeaponModel> ListData
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
        public FB_WeaponModel GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_WeaponModel);
        }
        public Dictionary<int, FB_WeaponModel> GetData()
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
            if (!FB_WeaponModelContainer.FB_WeaponModelContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_WeaponModelContainer.GetRootAsFB_WeaponModelContainer(bb);
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
