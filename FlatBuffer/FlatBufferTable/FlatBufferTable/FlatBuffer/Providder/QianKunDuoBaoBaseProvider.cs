using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_QianKunDuoBaoBaseProvider
    {
        private static FB_QianKunDuoBaoBaseProvider _Instance;
        public static FB_QianKunDuoBaoBaseProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_QianKunDuoBaoBaseProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/QianKunDuoBaoBase.txt";
        protected Dictionary<int, FB_QianKunDuoBaoBase> mData = new Dictionary<int, FB_QianKunDuoBaoBase>();
        private List<FB_QianKunDuoBaoBase> mListData = new List<FB_QianKunDuoBaoBase>();
        public List<FB_QianKunDuoBaoBase> ListData
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
        public FB_QianKunDuoBaoBase GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_QianKunDuoBaoBase);
        }
        public Dictionary<int, FB_QianKunDuoBaoBase> GetData()
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
            if (!FB_QianKunDuoBaoBaseContainer.FB_QianKunDuoBaoBaseContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_QianKunDuoBaoBaseContainer.GetRootAsFB_QianKunDuoBaoBaseContainer(bb);
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
