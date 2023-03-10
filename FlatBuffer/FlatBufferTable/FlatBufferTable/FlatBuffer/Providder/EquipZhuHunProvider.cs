using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_EquipZhuHunProvider
    {
        private static FB_EquipZhuHunProvider _Instance;
        public static FB_EquipZhuHunProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_EquipZhuHunProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/EquipZhuHun.txt";
        protected Dictionary<int, FB_EquipZhuHun> mData = new Dictionary<int, FB_EquipZhuHun>();
        private List<FB_EquipZhuHun> mListData = new List<FB_EquipZhuHun>();
        public List<FB_EquipZhuHun> ListData
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
        public FB_EquipZhuHun GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_EquipZhuHun);
        }
        public Dictionary<int, FB_EquipZhuHun> GetData()
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
            if (!FB_EquipZhuHunContainer.FB_EquipZhuHunContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_EquipZhuHunContainer.GetRootAsFB_EquipZhuHunContainer(bb);
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
