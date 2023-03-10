using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_EquipPartZhuHunBaoShiProvider
    {
        private static FB_EquipPartZhuHunBaoShiProvider _Instance;
        public static FB_EquipPartZhuHunBaoShiProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_EquipPartZhuHunBaoShiProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/EquipPartZhuHunBaoShi.txt";
        protected Dictionary<int, FB_EquipPartZhuHunBaoShi> mData = new Dictionary<int, FB_EquipPartZhuHunBaoShi>();
        private List<FB_EquipPartZhuHunBaoShi> mListData = new List<FB_EquipPartZhuHunBaoShi>();
        public List<FB_EquipPartZhuHunBaoShi> ListData
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
        public FB_EquipPartZhuHunBaoShi GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_EquipPartZhuHunBaoShi);
        }
        public Dictionary<int, FB_EquipPartZhuHunBaoShi> GetData()
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
            if (!FB_EquipPartZhuHunBaoShiContainer.FB_EquipPartZhuHunBaoShiContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_EquipPartZhuHunBaoShiContainer.GetRootAsFB_EquipPartZhuHunBaoShiContainer(bb);
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
